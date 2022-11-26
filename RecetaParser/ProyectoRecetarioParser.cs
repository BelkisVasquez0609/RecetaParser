//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\Belkis Vasquez\source\repos\RecetaParser\RecetaParser\ProyectoRecetario.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class ProyectoRecetarioParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, REC_LBL=2, POR_LBL=3, TIEMP_PREP_LBL=4, TIEMP_COC_LBL=5, CAL_LBL=6, 
		INGR_LBL=7, ELAB_LBL=8, SEP=9, SP=10, COMA=11, PAR=12, NUM=13, TEXT=14, 
		WORD=15, GUION=16, NEWLINE=17;
	public const int
		RULE_program = 0, RULE_receta = 1, RULE_nombre = 2, RULE_porciones = 3, 
		RULE_tiempoPreparacion = 4, RULE_tiempoCoccion = 5, RULE_calorias = 6, 
		RULE_ingredientes = 7, RULE_det_ingredientes = 8, RULE_elaboracion = 9, 
		RULE_det_elaboracion = 10;
	public static readonly string[] ruleNames = {
		"program", "receta", "nombre", "porciones", "tiempoPreparacion", "tiempoCoccion", 
		"calorias", "ingredientes", "det_ingredientes", "elaboracion", "det_elaboracion"
	};

	private static readonly string[] _LiteralNames = {
		null, "' '", "'RECETA'", "'PORCIONES'", "'TIEMPO PREPARACION'", "'TIEMPO COCCION'", 
		"'CALORIAS'", "'INGREDIENTES'", "'ELABORACION'", null, null, "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "REC_LBL", "POR_LBL", "TIEMP_PREP_LBL", "TIEMP_COC_LBL", "CAL_LBL", 
		"INGR_LBL", "ELAB_LBL", "SEP", "SP", "COMA", "PAR", "NUM", "TEXT", "WORD", 
		"GUION", "NEWLINE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ProyectoRecetario.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ProyectoRecetarioParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public ProyectoRecetarioParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public ProyectoRecetarioParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgramContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(ProyectoRecetarioParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public RecetaContext[] receta() {
			return GetRuleContexts<RecetaContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public RecetaContext receta(int i) {
			return GetRuleContext<RecetaContext>(i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 23;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 22;
				receta();
				}
				}
				State = 25;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==GUION );
			State = 27;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RecetaContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NombreContext nombre() {
			return GetRuleContext<NombreContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PorcionesContext porciones() {
			return GetRuleContext<PorcionesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CaloriasContext calorias() {
			return GetRuleContext<CaloriasContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IngredientesContext ingredientes() {
			return GetRuleContext<IngredientesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElaboracionContext elaboracion() {
			return GetRuleContext<ElaboracionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TiempoPreparacionContext tiempoPreparacion() {
			return GetRuleContext<TiempoPreparacionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TiempoCoccionContext tiempoCoccion() {
			return GetRuleContext<TiempoCoccionContext>(0);
		}
		public RecetaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_receta; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitReceta(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RecetaContext receta() {
		RecetaContext _localctx = new RecetaContext(Context, State);
		EnterRule(_localctx, 2, RULE_receta);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 29;
			nombre();
			State = 30;
			porciones();
			State = 32;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				{
				State = 31;
				tiempoPreparacion();
				}
				break;
			}
			State = 35;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				{
				State = 34;
				tiempoCoccion();
				}
				break;
			}
			State = 37;
			calorias();
			State = 38;
			ingredientes();
			State = 39;
			elaboracion();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NombreContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GUION() { return GetToken(ProyectoRecetarioParser.GUION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REC_LBL() { return GetToken(ProyectoRecetarioParser.REC_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(ProyectoRecetarioParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(ProyectoRecetarioParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(ProyectoRecetarioParser.SP, 0); }
		public NombreContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_nombre; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNombre(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NombreContext nombre() {
		NombreContext _localctx = new NombreContext(Context, State);
		EnterRule(_localctx, 4, RULE_nombre);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 41;
			Match(GUION);
			State = 42;
			Match(REC_LBL);
			State = 43;
			Match(SEP);
			State = 44;
			Match(TEXT);
			State = 46;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 45;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PorcionesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GUION() { return GetToken(ProyectoRecetarioParser.GUION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode POR_LBL() { return GetToken(ProyectoRecetarioParser.POR_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(ProyectoRecetarioParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(ProyectoRecetarioParser.NUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(ProyectoRecetarioParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(ProyectoRecetarioParser.SP, 0); }
		public PorcionesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_porciones; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPorciones(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PorcionesContext porciones() {
		PorcionesContext _localctx = new PorcionesContext(Context, State);
		EnterRule(_localctx, 6, RULE_porciones);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 48;
			Match(GUION);
			State = 49;
			Match(POR_LBL);
			State = 50;
			Match(SEP);
			State = 51;
			Match(NUM);
			State = 52;
			Match(TEXT);
			State = 54;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 53;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TiempoPreparacionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GUION() { return GetToken(ProyectoRecetarioParser.GUION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TIEMP_PREP_LBL() { return GetToken(ProyectoRecetarioParser.TIEMP_PREP_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(ProyectoRecetarioParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(ProyectoRecetarioParser.NUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(ProyectoRecetarioParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(ProyectoRecetarioParser.SP, 0); }
		public TiempoPreparacionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tiempoPreparacion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTiempoPreparacion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TiempoPreparacionContext tiempoPreparacion() {
		TiempoPreparacionContext _localctx = new TiempoPreparacionContext(Context, State);
		EnterRule(_localctx, 8, RULE_tiempoPreparacion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 56;
			Match(GUION);
			State = 57;
			Match(TIEMP_PREP_LBL);
			State = 58;
			Match(SEP);
			State = 59;
			Match(NUM);
			State = 60;
			Match(TEXT);
			State = 62;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 61;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TiempoCoccionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GUION() { return GetToken(ProyectoRecetarioParser.GUION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TIEMP_COC_LBL() { return GetToken(ProyectoRecetarioParser.TIEMP_COC_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(ProyectoRecetarioParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(ProyectoRecetarioParser.NUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(ProyectoRecetarioParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(ProyectoRecetarioParser.SP, 0); }
		public TiempoCoccionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tiempoCoccion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTiempoCoccion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TiempoCoccionContext tiempoCoccion() {
		TiempoCoccionContext _localctx = new TiempoCoccionContext(Context, State);
		EnterRule(_localctx, 10, RULE_tiempoCoccion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 64;
			Match(GUION);
			State = 65;
			Match(TIEMP_COC_LBL);
			State = 66;
			Match(SEP);
			State = 67;
			Match(NUM);
			State = 68;
			Match(TEXT);
			State = 70;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 69;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CaloriasContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GUION() { return GetToken(ProyectoRecetarioParser.GUION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CAL_LBL() { return GetToken(ProyectoRecetarioParser.CAL_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(ProyectoRecetarioParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(ProyectoRecetarioParser.NUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(ProyectoRecetarioParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(ProyectoRecetarioParser.SP, 0); }
		public CaloriasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_calorias; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCalorias(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CaloriasContext calorias() {
		CaloriasContext _localctx = new CaloriasContext(Context, State);
		EnterRule(_localctx, 12, RULE_calorias);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 72;
			Match(GUION);
			State = 73;
			Match(CAL_LBL);
			State = 74;
			Match(SEP);
			State = 75;
			Match(NUM);
			State = 76;
			Match(TEXT);
			State = 78;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 77;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IngredientesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INGR_LBL() { return GetToken(ProyectoRecetarioParser.INGR_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(ProyectoRecetarioParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GUION() { return GetToken(ProyectoRecetarioParser.GUION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Det_ingredientesContext[] det_ingredientes() {
			return GetRuleContexts<Det_ingredientesContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Det_ingredientesContext det_ingredientes(int i) {
			return GetRuleContext<Det_ingredientesContext>(i);
		}
		public IngredientesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ingredientes; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIngredientes(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IngredientesContext ingredientes() {
		IngredientesContext _localctx = new IngredientesContext(Context, State);
		EnterRule(_localctx, 14, RULE_ingredientes);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 81;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==GUION) {
				{
				State = 80;
				Match(GUION);
				}
			}

			State = 83;
			Match(INGR_LBL);
			State = 84;
			Match(SEP);
			State = 86;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 85;
				det_ingredientes();
				}
				}
				State = 88;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==T__0 || _la==NUM );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Det_ingredientesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(ProyectoRecetarioParser.NUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(ProyectoRecetarioParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMA() { return GetToken(ProyectoRecetarioParser.COMA, 0); }
		public Det_ingredientesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_det_ingredientes; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDet_ingredientes(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Det_ingredientesContext det_ingredientes() {
		Det_ingredientesContext _localctx = new Det_ingredientesContext(Context, State);
		EnterRule(_localctx, 16, RULE_det_ingredientes);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 93;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__0) {
				{
				{
				State = 90;
				Match(T__0);
				}
				}
				State = 95;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 96;
			Match(NUM);
			State = 97;
			Match(TEXT);
			State = 99;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMA) {
				{
				State = 98;
				Match(COMA);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElaboracionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GUION() { return GetToken(ProyectoRecetarioParser.GUION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELAB_LBL() { return GetToken(ProyectoRecetarioParser.ELAB_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(ProyectoRecetarioParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Det_elaboracionContext[] det_elaboracion() {
			return GetRuleContexts<Det_elaboracionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Det_elaboracionContext det_elaboracion(int i) {
			return GetRuleContext<Det_elaboracionContext>(i);
		}
		public ElaboracionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elaboracion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElaboracion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElaboracionContext elaboracion() {
		ElaboracionContext _localctx = new ElaboracionContext(Context, State);
		EnterRule(_localctx, 18, RULE_elaboracion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 101;
			Match(GUION);
			State = 102;
			Match(ELAB_LBL);
			State = 103;
			Match(SEP);
			State = 105;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 104;
				det_elaboracion();
				}
				}
				State = 107;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==NUM );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Det_elaboracionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(ProyectoRecetarioParser.NUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PAR() { return GetToken(ProyectoRecetarioParser.PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(ProyectoRecetarioParser.TEXT, 0); }
		public Det_elaboracionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_det_elaboracion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IProyectoRecetarioVisitor<TResult> typedVisitor = visitor as IProyectoRecetarioVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDet_elaboracion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Det_elaboracionContext det_elaboracion() {
		Det_elaboracionContext _localctx = new Det_elaboracionContext(Context, State);
		EnterRule(_localctx, 20, RULE_det_elaboracion);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 109;
			Match(NUM);
			State = 110;
			Match(PAR);
			State = 111;
			Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x13', 't', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x4', '\f', '\t', '\f', '\x3', '\x2', '\x6', '\x2', '\x1A', '\n', '\x2', 
		'\r', '\x2', '\xE', '\x2', '\x1B', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '#', '\n', '\x3', '\x3', 
		'\x3', '\x5', '\x3', '&', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x5', '\x4', '\x31', '\n', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x5', '\x5', '\x39', '\n', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', '\x41', 
		'\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x5', '\a', 'I', '\n', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', 'Q', 
		'\n', '\b', '\x3', '\t', '\x5', '\t', 'T', '\n', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x6', '\t', 'Y', '\n', '\t', '\r', '\t', '\xE', '\t', 
		'Z', '\x3', '\n', '\a', '\n', '^', '\n', '\n', '\f', '\n', '\xE', '\n', 
		'\x61', '\v', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', 
		'\x66', '\n', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x6', '\v', 'l', '\n', '\v', '\r', '\v', '\xE', '\v', 'm', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x2', '\x2', '\r', 
		'\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x10', '\x12', '\x14', 
		'\x16', '\x2', '\x2', '\x2', 'u', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x4', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x6', '+', '\x3', '\x2', 
		'\x2', '\x2', '\b', '\x32', '\x3', '\x2', '\x2', '\x2', '\n', ':', '\x3', 
		'\x2', '\x2', '\x2', '\f', '\x42', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'J', '\x3', '\x2', '\x2', '\x2', '\x10', 'S', '\x3', '\x2', '\x2', '\x2', 
		'\x12', '_', '\x3', '\x2', '\x2', '\x2', '\x14', 'g', '\x3', '\x2', '\x2', 
		'\x2', '\x16', 'o', '\x3', '\x2', '\x2', '\x2', '\x18', '\x1A', '\x5', 
		'\x4', '\x3', '\x2', '\x19', '\x18', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x1E', '\a', '\x2', '\x2', '\x3', '\x1E', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\x5', '\x6', '\x4', '\x2', 
		' ', '\"', '\x5', '\b', '\x5', '\x2', '!', '#', '\x5', '\n', '\x6', '\x2', 
		'\"', '!', '\x3', '\x2', '\x2', '\x2', '\"', '#', '\x3', '\x2', '\x2', 
		'\x2', '#', '%', '\x3', '\x2', '\x2', '\x2', '$', '&', '\x5', '\f', '\a', 
		'\x2', '%', '$', '\x3', '\x2', '\x2', '\x2', '%', '&', '\x3', '\x2', '\x2', 
		'\x2', '&', '\'', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\x5', '\xE', 
		'\b', '\x2', '(', ')', '\x5', '\x10', '\t', '\x2', ')', '*', '\x5', '\x14', 
		'\v', '\x2', '*', '\x5', '\x3', '\x2', '\x2', '\x2', '+', ',', '\a', '\x12', 
		'\x2', '\x2', ',', '-', '\a', '\x4', '\x2', '\x2', '-', '.', '\a', '\v', 
		'\x2', '\x2', '.', '\x30', '\a', '\x10', '\x2', '\x2', '/', '\x31', '\a', 
		'\f', '\x2', '\x2', '\x30', '/', '\x3', '\x2', '\x2', '\x2', '\x30', '\x31', 
		'\x3', '\x2', '\x2', '\x2', '\x31', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x32', '\x33', '\a', '\x12', '\x2', '\x2', '\x33', '\x34', '\a', '\x5', 
		'\x2', '\x2', '\x34', '\x35', '\a', '\v', '\x2', '\x2', '\x35', '\x36', 
		'\a', '\xF', '\x2', '\x2', '\x36', '\x38', '\a', '\x10', '\x2', '\x2', 
		'\x37', '\x39', '\a', '\f', '\x2', '\x2', '\x38', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\x38', '\x39', '\x3', '\x2', '\x2', '\x2', '\x39', '\t', 
		'\x3', '\x2', '\x2', '\x2', ':', ';', '\a', '\x12', '\x2', '\x2', ';', 
		'<', '\a', '\x6', '\x2', '\x2', '<', '=', '\a', '\v', '\x2', '\x2', '=', 
		'>', '\a', '\xF', '\x2', '\x2', '>', '@', '\a', '\x10', '\x2', '\x2', 
		'?', '\x41', '\a', '\f', '\x2', '\x2', '@', '?', '\x3', '\x2', '\x2', 
		'\x2', '@', '\x41', '\x3', '\x2', '\x2', '\x2', '\x41', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x42', '\x43', '\a', '\x12', '\x2', '\x2', '\x43', '\x44', 
		'\a', '\a', '\x2', '\x2', '\x44', '\x45', '\a', '\v', '\x2', '\x2', '\x45', 
		'\x46', '\a', '\xF', '\x2', '\x2', '\x46', 'H', '\a', '\x10', '\x2', '\x2', 
		'G', 'I', '\a', '\f', '\x2', '\x2', 'H', 'G', '\x3', '\x2', '\x2', '\x2', 
		'H', 'I', '\x3', '\x2', '\x2', '\x2', 'I', '\r', '\x3', '\x2', '\x2', 
		'\x2', 'J', 'K', '\a', '\x12', '\x2', '\x2', 'K', 'L', '\a', '\b', '\x2', 
		'\x2', 'L', 'M', '\a', '\v', '\x2', '\x2', 'M', 'N', '\a', '\xF', '\x2', 
		'\x2', 'N', 'P', '\a', '\x10', '\x2', '\x2', 'O', 'Q', '\a', '\f', '\x2', 
		'\x2', 'P', 'O', '\x3', '\x2', '\x2', '\x2', 'P', 'Q', '\x3', '\x2', '\x2', 
		'\x2', 'Q', '\xF', '\x3', '\x2', '\x2', '\x2', 'R', 'T', '\a', '\x12', 
		'\x2', '\x2', 'S', 'R', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x3', '\x2', 
		'\x2', '\x2', 'T', 'U', '\x3', '\x2', '\x2', '\x2', 'U', 'V', '\a', '\t', 
		'\x2', '\x2', 'V', 'X', '\a', '\v', '\x2', '\x2', 'W', 'Y', '\x5', '\x12', 
		'\n', '\x2', 'X', 'W', '\x3', '\x2', '\x2', '\x2', 'Y', 'Z', '\x3', '\x2', 
		'\x2', '\x2', 'Z', 'X', '\x3', '\x2', '\x2', '\x2', 'Z', '[', '\x3', '\x2', 
		'\x2', '\x2', '[', '\x11', '\x3', '\x2', '\x2', '\x2', '\\', '^', '\a', 
		'\x3', '\x2', '\x2', ']', '\\', '\x3', '\x2', '\x2', '\x2', '^', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '_', ']', '\x3', '\x2', '\x2', '\x2', '_', 
		'`', '\x3', '\x2', '\x2', '\x2', '`', '\x62', '\x3', '\x2', '\x2', '\x2', 
		'\x61', '_', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\a', '\xF', 
		'\x2', '\x2', '\x63', '\x65', '\a', '\x10', '\x2', '\x2', '\x64', '\x66', 
		'\a', '\r', '\x2', '\x2', '\x65', '\x64', '\x3', '\x2', '\x2', '\x2', 
		'\x65', '\x66', '\x3', '\x2', '\x2', '\x2', '\x66', '\x13', '\x3', '\x2', 
		'\x2', '\x2', 'g', 'h', '\a', '\x12', '\x2', '\x2', 'h', 'i', '\a', '\n', 
		'\x2', '\x2', 'i', 'k', '\a', '\v', '\x2', '\x2', 'j', 'l', '\x5', '\x16', 
		'\f', '\x2', 'k', 'j', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\x3', '\x2', 
		'\x2', '\x2', 'm', 'k', '\x3', '\x2', '\x2', '\x2', 'm', 'n', '\x3', '\x2', 
		'\x2', '\x2', 'n', '\x15', '\x3', '\x2', '\x2', '\x2', 'o', 'p', '\a', 
		'\xF', '\x2', '\x2', 'p', 'q', '\a', '\xE', '\x2', '\x2', 'q', 'r', '\a', 
		'\x10', '\x2', '\x2', 'r', '\x17', '\x3', '\x2', '\x2', '\x2', '\xF', 
		'\x1B', '\"', '%', '\x30', '\x38', '@', 'H', 'P', 'S', 'Z', '_', '\x65', 
		'm',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
