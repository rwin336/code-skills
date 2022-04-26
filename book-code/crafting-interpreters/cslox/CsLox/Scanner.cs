using static com.craftinginterpreters.lox.TokenType;

namespace com.craftinginterpreters.lox
{

    public class Scanner 
    {
        private readonly string source;
        private readonly List<Token> tokens = new List<Token>();

        private int start;
        private int current;
        private int line = 1;

        public Scanner(string source)
        {
            this.source = source;
        }

        public List<Token> scanTokens() 
        {
            while(!isAtEnd())
            {
                // We are at the begining of the next lexeme
                start = current;
                scanToken();
            }

            tokens.Add(new Token(EOF, "", null, line));
            return tokens;
        }

        private bool isAtEnd() {
            return current >= source.Length;
        }

        private void scanToken() 
        {
            char c = advance();
            switch(c)
            {
                case '(':
                    addToken(LEFT_PAREN);
                    break;
                case ')':
                    addToken(RIGHT_PAREN);
                    break;
                case '{':
                    addToken(LEFT_BRACE);
                    break;
                case '}':
                    addToken(RIGHT_BRACE);
                    break;
                case ',':
                    addToken(COMMA);
                    break;
                case '.':
                    addToken(DOT);
                    break;
                case '-':
                    addToken(MINUS);
                    break;
                case '+':
                    addToken(PLUS);
                    break;
                case ';':
                    addToken(SEMICOLON);
                    break;
                case '*':
                    addToken(STAR);
                    break;
                case '!':
                    addToken(match('=') ? BANG_EQUAL : BANG);
                    break;
                case '=':
                    addToken(match('=') ? EQUAL_EQUAL : EQUAL);
                    break;
                case '<':
                    addToken(match('=') ? LESS_EQUAL : LESS);
                    break;
                case '>':
                    addToken(match('=') ? GREATER_EQUAL : GREATER);
                    break;
                case '/':
                    if(match('/'))
                    {
                        while(peek() != '\n' && !isAtEnd())
                        {
                            advance();
                        }
                    }
                    else
                    {
                        addToken(SLASH);
                    }
                    break;

                case ' ':
                case '\r':
                case '\t':
                    // Ignore whitespace
                    break;
                case '\n':
                    line++;
                    break;
                case '"': 
                    LiteralString();
                    break;
                default:
                    Lox.error(line, "Unexpected charater.");
                    break;
            }
        }

        private void LiteralString() 
        {
            while(peek() != '"' && !isAtEnd())
            {
                if(peek() == '\n')
                {
                    line++;
                }
                advance();
            }

            if(isAtEnd())
            {   
                Lox.error(line, "Unterminated string.");
                return;
            }

            advance();  // The closing ".

            // Trim the surrounding quotes.
            String value = source.Substring(start + 1, current - 1);
            addToken(STRING, value);
        }

        private bool match(char expected)
        {
            if(isAtEnd())
            {
                return false;
            }

            if(source[current] != expected)
            {
                return false;
            }

            current++;
            return true;
        }

        private char peek()
        {
            if(isAtEnd())
            {
                return '\0';
            }
            return source[current];
        }

        private char advance() 
        {
            return source[current++];
        }

        private void addToken(TokenType type)
        {
            addToken(type, null);
        }

        private void addToken(TokenType type, Object? literal)
        {
            try {
                string text = source.Substring(start, (current - start));
                tokens.Add(new Token(type, text, literal, line));
            }
            catch(System.ArgumentOutOfRangeException)
            {
                Lox.error(line, $"OOB: source len: {source.Length} {start} {current}");
            }
        }

    }

}