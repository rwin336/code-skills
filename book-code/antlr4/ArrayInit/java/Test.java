// import ANTLR's runtime libraries
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.tree.*;

public class Test {
    public static void main(String[] args) throws Exception {
	// create a CharSting that reads from the standard input.
	ANTLRInputStream input = new ANTLRInputStream(System.in);

	// create a lexer that feeds off of input CharStream
	ArrayInitLexer lexer = new ArrayInitLexer(input);

	// create a buffer of tokens pulled from the lexer
	CommonTokenStream tokens = new CommonTokenStream(lexer);

	// create a parser that feeds off the tokens buffer
	ArrayInitParser parser = new ArrayInitParser(tokens);

	ParseTree tree = parser.init();  // begin parsing at init role
	System.out.println(tree.toStringTree(parser));  // print the lisp style tree
    }
}
