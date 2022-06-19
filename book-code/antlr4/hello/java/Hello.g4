grammar Hello;			// Define a grammar called Hello
r  : 'hello' ID ;		// match keyword
ID : [a-z]+ ;			// match lower case identifiers
WS : [ \t\r\n]+ -> skip ;	// skip spaces, tabs newlines, \r