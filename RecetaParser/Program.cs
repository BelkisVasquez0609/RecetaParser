using Antlr4.Runtime;
using RecetaParser;
using static RecetaParser.AnalizadorReceta;

var input = CharStreams.fromPath(@"..\..\..\Recetario.txt");

var lexer = new ProyectoRecetarioLexer(input); 
var tokenStream = new CommonTokenStream(lexer); 
var parser = new ProyectoRecetarioParser(tokenStream); 
var tree = parser.program();

AnalizadorReceta recetaToSQL = new AnalizadorReceta();
Console.WriteLine(recetaToSQL.Visit(tree));