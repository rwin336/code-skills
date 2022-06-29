grammar LabeledExpr;
import CommonLexerRules;

/** The start rule; begin parsing here */
prog:    stat+ ;

stat:	 expr NEWLINE           # printExpr
    |	 ID '=' expr NEWLINE	# assign
    |	 NEWLINE     		# blank
    ;

expr:	expr ('*'|'/') expr	# MulDiv
    |	expr ('+'|'-') expr	# AddSub
    |	INT  	       		# int
    |	ID			# id
    |	'(' expr ')'		# parens
    ;

MUL :	'*' ;	// assigns token name to '*' used in above grammar
DIV :	'/' ;
ADD :   '+' ;
SUB :   '-' ;


