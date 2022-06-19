##
## Makefile for ArrayList
##

PARSER=ArrayInit
OUTPUT=output
GENERATED=generated
GRAMMAR=ArrayInit.g4
ANTLR_JAR=/usr/local/lib/antlr-4.10.1-complete.jar
JFLAGS=-g
JAVA_HOME=/opt/java/jdk-17/bin
JAVA=$(JAVA_HOME)/java
JAVAC=$(JAVA_HOME)/javac

.SUFFIXES: .java .class
.java.class:
	$(JAVAC) $(JFLAGS) $*.java


all: dirs antlr4 


antlr4: $(GRAMMAR)
	$(JAVA) -jar $(ANTLR_JAR) -o $(GENERATED) $(GRAMMAR)

dirs:
	mkdir -p $(OUTPUT)
	mkdir -p $(GENERATED)

clean:
	$(RM) -rf $(OUTPUT)
	$(RM) -rf $(GENERATED)
