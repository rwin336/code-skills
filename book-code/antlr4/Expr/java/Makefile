##
## Makefile for ArrayList
##

PARSER=Expr
OUTPUT=output
GENERATED=generated
GRAMMAR=Expr.g4
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

CLASSES= 
classes: $(CLASSES:.java=.class)

antlr4: $(GRAMMAR)
	$(JAVA) -jar $(ANTLR_JAR) -o $(GENERATED) $(GRAMMAR)
	$(JAVAC) $(JFLAGS) -d $(OUTPUT) $(GENERATED)/*.java

dirs:
	mkdir -p $(OUTPUT)
	mkdir -p $(GENERATED)

clean:
	$(RM) -rf $(OUTPUT)
	$(RM) -rf $(GENERATED)
