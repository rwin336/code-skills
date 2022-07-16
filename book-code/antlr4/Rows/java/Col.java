import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.tree.*;
import java.io.FileInputStream;
import java.io.InputStream;
import java.lang.Integer;

public class Col {

    public static void main(String[] args) throws Exception {
	String inputFile = null;
	if( args.length > 1) {
	    inputFile = args[2];
	}
	
	InputStream is = System.in;

	if( inputFile != null ) {
	    is = new FileInputStream(inputFile);
	}

	ANTLRInputStream input = new ANTLRInputStream(is);
	RowsLexer lexer = new RowsLexer(input);
	CommonTokenStream tokes = new CommonTokenStream(lexer);
	int col = Integer.valueOf(args[0]);
	RowsParser parser = new RowsParser(tokes, col);  // pass column number
	parser.setBuildParseTree(false);                 // don't waste time building tree
	parser.file();                                   // parse
	
    }
}
