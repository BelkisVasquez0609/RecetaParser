grammar ProyectoRecetario;

//Parsing rules 

program: (receta)+ EOF;
receta : nombre porciones tiempoPreparacion? tiempoCoccion? calorias ingredientes elaboracion;
nombre: GUION REC_LBL SEP TEXT SP?;
porciones: GUION POR_LBL SEP NUM TEXT SP?;
tiempoPreparacion: GUION TIEMP_PREP_LBL SEP NUM TEXT SP?;
tiempoCoccion: GUION TIEMP_COC_LBL SEP NUM TEXT SP?;
calorias: GUION CAL_LBL SEP NUM TEXT SP?;

ingredientes : GUION? INGR_LBL SEP (det_ingredientes)+;
det_ingredientes : ' '* NUM TEXT COMA?;

elaboracion: GUION ELAB_LBL SEP (det_elaboracion)+;
det_elaboracion: NUM PAR TEXT;

//Lexer Rules:

REC_LBL: 'RECETA' ;
POR_LBL: 'PORCIONES';
TIEMP_PREP_LBL: 'TIEMPO PREPARACION';
TIEMP_COC_LBL: 'TIEMPO COCCION';
CAL_LBL: 'CALORIAS';
INGR_LBL: 'INGREDIENTES';
ELAB_LBL: 'ELABORACION';

SEP: SP? ':' SP?;
SP : ' '+;
COMA: ',';
PAR: ')'SP?;

NUM: SP* [0-9]+ '.'? [0-9]* SP?;
TEXT : WORD (SP WORD)*;
WORD : [A-Za-z_]+ ;
GUION : '-' SP;
NEWLINE: [ \t\r\n] -> skip;