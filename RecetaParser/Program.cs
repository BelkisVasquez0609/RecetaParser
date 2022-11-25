using Antlr4.Runtime;

var input = CharStreams.fromPath(@"..\..\..\Recetario.txt");

var lexer = new ProyectoRecetarioLexer(input); 
var tokenStream = new CommonTokenStream(lexer); 
var parser = new ProyectoRecetarioParser(tokenStream); 
var tree = parser.program(); 

//var visitor