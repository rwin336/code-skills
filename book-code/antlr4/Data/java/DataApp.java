import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.tree.*;
import java.io.FileInputStream;
import java.io.InputStream;
import java.lang.Integer;

public class DataApp {

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
	DataLexer lexer = new DataLexer(input);
	CommonTokenStream tokes = new CommonTokenStream(lexer);
	
    }
}
