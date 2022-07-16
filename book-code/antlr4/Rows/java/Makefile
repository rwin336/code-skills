##
## Makefile for Rows
##

## Update vars via command line example:
##
##   $ make JAVA_HOME=/usr/bin

PARSER=Rows
OUTPUT=output
GENERATED=generated
GRAMMAR=Rows.g4
ANTLR_JAR=/usr/local/lib/antlr-4.10.1-complete.jar
JFLAGS=-g
JAVA_HOME=/opt/java/jdk-17/bin
JAVA=$(JAVA_HOME)/java
JAVAC=$(JAVA_HOME)/javac
CLASSPATH=.:/usr/local/lib/antlr-4.10.1-complete.jar:./$(OUTPUT)

.SUFFIXES: .java .class
.java.class:
	$(JAVAC) $(JFLAGS) -cp $(CLASSPATH) -d $(OUTPUT) $*.java


all: dirs antlr4 classes

#CLASSES= ExprJoyRide.java Calc.java
CLASSES= Col.java
classes: $(CLASSES:.java=.class)

# 	$(JAVA) -jar $(ANTLR_JAR) -no-listener -visitor -o $(GENERATED) $(GRAMMAR)
#	$(JAVA) -jar $(ANTLR_JAR) -o $(GENERATED) Expr.g4

antlr4: $(GRAMMAR)
	$(JAVA) -jar $(ANTLR_JAR) -o $(GENERATED) $(GRAMMAR)
	$(JAVAC) $(JFLAGS) -d $(OUTPUT) $(GENERATED)/*.java

dirs:
	mkdir -p $(OUTPUT)
	mkdir -p $(GENERATED)

clean:
	$(RM) -rf $(OUTPUT)
	$(RM) -rf $(GENERATED)
	$(RM) *~
