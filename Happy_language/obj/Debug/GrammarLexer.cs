//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.4-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Jan\Documents\Visual Studio 2015\Projects\Happy_language\Happy_language\Grammar.g4 by ANTLR 4.5.4-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Happy_language {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.4-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class GrammarLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, Comment=12, Line_comment=13, Semi=14, Assign=15, Bracket_left=16, 
		Bracket_right=17, Data_type_void=18, Data_type_bool=19, Data_type_double=20, 
		Data_type_int=21, Function_def=22, Const=23, If=24, Else=25, Operator_condition=26, 
		Start_prog=27, Main_name=28, Bool=29, Start_blok=30, End_blok=31, Int=32, 
		Double=33, Identifier=34, WS=35;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "Comment", "Line_comment", "Semi", "Assign", "Bracket_left", 
		"Bracket_right", "Data_type_void", "Data_type_bool", "Data_type_double", 
		"Data_type_int", "Function_def", "Const", "If", "Else", "Operator_condition", 
		"Start_prog", "Main_name", "Bool", "Start_blok", "End_blok", "Int", "Double", 
		"Identifier", "WS"
	};


	public GrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "','", "'while'", "'for'", "'+'", "'-'", "'/'", "'*'", "'('", "')'", 
		"'||'", "'&&'", null, null, "';)'", "':='", "'(:'", "':)'", "':V'", "':B'", 
		"':D'", "':I'", "'def'", "'const'", "'if'", "'else'", null, "'happy_start'", 
		"'mainSmile'", null, "'{:'", "':}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"Comment", "Line_comment", "Semi", "Assign", "Bracket_left", "Bracket_right", 
		"Data_type_void", "Data_type_bool", "Data_type_double", "Data_type_int", 
		"Function_def", "Const", "If", "Else", "Operator_condition", "Start_prog", 
		"Main_name", "Bool", "Start_blok", "End_blok", "Int", "Double", "Identifier", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Grammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2%\x105\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3"+
		"\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3"+
		"\r\a\rl\n\r\f\r\xE\ro\v\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3"+
		"\xE\x3\xE\a\xE{\n\xE\f\xE\xE\xE~\v\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3"+
		"\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3"+
		"\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3"+
		"\x16\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3"+
		"\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3"+
		"\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x5\x1B\xB5\n\x1B"+
		"\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C"+
		"\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D"+
		"\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E"+
		"\x3\x1E\x5\x1E\xD6\n\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3!\x5!\xDF"+
		"\n!\x3!\x6!\xE2\n!\r!\xE!\xE3\x3\"\x5\"\xE7\n\"\x3\"\x6\"\xEA\n\"\r\""+
		"\xE\"\xEB\x3\"\x3\"\x6\"\xF0\n\"\r\"\xE\"\xF1\x3#\x6#\xF5\n#\r#\xE#\xF6"+
		"\x3#\a#\xFA\n#\f#\xE#\xFD\v#\x3$\x6$\x100\n$\r$\xE$\x101\x3$\x3$\x3m\x2"+
		"\x2%\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n"+
		"\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11"+
		"!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31"+
		"\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!"+
		"\x41\x2\"\x43\x2#\x45\x2$G\x2%\x3\x2\t\x4\x2\f\f\xF\xF\x4\x2>>@@\x4\x2"+
		"--//\x3\x2\x32;\x4\x2\x43\\\x63|\x5\x2\x32;\x43\\\x63|\x5\x2\v\f\xF\xF"+
		"\"\"\x113\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3"+
		"\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3"+
		"\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2"+
		"\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2"+
		"\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2"+
		")\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3"+
		"\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2"+
		"\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41"+
		"\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x3"+
		"I\x3\x2\x2\x2\x5K\x3\x2\x2\x2\aQ\x3\x2\x2\x2\tU\x3\x2\x2\x2\vW\x3\x2\x2"+
		"\x2\rY\x3\x2\x2\x2\xF[\x3\x2\x2\x2\x11]\x3\x2\x2\x2\x13_\x3\x2\x2\x2\x15"+
		"\x61\x3\x2\x2\x2\x17\x64\x3\x2\x2\x2\x19g\x3\x2\x2\x2\x1Bu\x3\x2\x2\x2"+
		"\x1D\x81\x3\x2\x2\x2\x1F\x84\x3\x2\x2\x2!\x87\x3\x2\x2\x2#\x8A\x3\x2\x2"+
		"\x2%\x8D\x3\x2\x2\x2\'\x90\x3\x2\x2\x2)\x93\x3\x2\x2\x2+\x96\x3\x2\x2"+
		"\x2-\x99\x3\x2\x2\x2/\x9D\x3\x2\x2\x2\x31\xA3\x3\x2\x2\x2\x33\xA6\x3\x2"+
		"\x2\x2\x35\xB4\x3\x2\x2\x2\x37\xB6\x3\x2\x2\x2\x39\xC2\x3\x2\x2\x2;\xD5"+
		"\x3\x2\x2\x2=\xD7\x3\x2\x2\x2?\xDA\x3\x2\x2\x2\x41\xDE\x3\x2\x2\x2\x43"+
		"\xE6\x3\x2\x2\x2\x45\xF4\x3\x2\x2\x2G\xFF\x3\x2\x2\x2IJ\a.\x2\x2J\x4\x3"+
		"\x2\x2\x2KL\ay\x2\x2LM\aj\x2\x2MN\ak\x2\x2NO\an\x2\x2OP\ag\x2\x2P\x6\x3"+
		"\x2\x2\x2QR\ah\x2\x2RS\aq\x2\x2ST\at\x2\x2T\b\x3\x2\x2\x2UV\a-\x2\x2V"+
		"\n\x3\x2\x2\x2WX\a/\x2\x2X\f\x3\x2\x2\x2YZ\a\x31\x2\x2Z\xE\x3\x2\x2\x2"+
		"[\\\a,\x2\x2\\\x10\x3\x2\x2\x2]^\a*\x2\x2^\x12\x3\x2\x2\x2_`\a+\x2\x2"+
		"`\x14\x3\x2\x2\x2\x61\x62\a~\x2\x2\x62\x63\a~\x2\x2\x63\x16\x3\x2\x2\x2"+
		"\x64\x65\a(\x2\x2\x65\x66\a(\x2\x2\x66\x18\x3\x2\x2\x2gh\a<\x2\x2hi\a"+
		",\x2\x2im\x3\x2\x2\x2jl\v\x2\x2\x2kj\x3\x2\x2\x2lo\x3\x2\x2\x2mn\x3\x2"+
		"\x2\x2mk\x3\x2\x2\x2np\x3\x2\x2\x2om\x3\x2\x2\x2pq\a,\x2\x2qr\a<\x2\x2"+
		"rs\x3\x2\x2\x2st\b\r\x2\x2t\x1A\x3\x2\x2\x2uv\a<\x2\x2vw\a,\x2\x2wx\a"+
		",\x2\x2x|\x3\x2\x2\x2y{\n\x2\x2\x2zy\x3\x2\x2\x2{~\x3\x2\x2\x2|z\x3\x2"+
		"\x2\x2|}\x3\x2\x2\x2}\x7F\x3\x2\x2\x2~|\x3\x2\x2\x2\x7F\x80\b\xE\x2\x2"+
		"\x80\x1C\x3\x2\x2\x2\x81\x82\a=\x2\x2\x82\x83\a+\x2\x2\x83\x1E\x3\x2\x2"+
		"\x2\x84\x85\a<\x2\x2\x85\x86\a?\x2\x2\x86 \x3\x2\x2\x2\x87\x88\a*\x2\x2"+
		"\x88\x89\a<\x2\x2\x89\"\x3\x2\x2\x2\x8A\x8B\a<\x2\x2\x8B\x8C\a+\x2\x2"+
		"\x8C$\x3\x2\x2\x2\x8D\x8E\a<\x2\x2\x8E\x8F\aX\x2\x2\x8F&\x3\x2\x2\x2\x90"+
		"\x91\a<\x2\x2\x91\x92\a\x44\x2\x2\x92(\x3\x2\x2\x2\x93\x94\a<\x2\x2\x94"+
		"\x95\a\x46\x2\x2\x95*\x3\x2\x2\x2\x96\x97\a<\x2\x2\x97\x98\aK\x2\x2\x98"+
		",\x3\x2\x2\x2\x99\x9A\a\x66\x2\x2\x9A\x9B\ag\x2\x2\x9B\x9C\ah\x2\x2\x9C"+
		".\x3\x2\x2\x2\x9D\x9E\a\x65\x2\x2\x9E\x9F\aq\x2\x2\x9F\xA0\ap\x2\x2\xA0"+
		"\xA1\au\x2\x2\xA1\xA2\av\x2\x2\xA2\x30\x3\x2\x2\x2\xA3\xA4\ak\x2\x2\xA4"+
		"\xA5\ah\x2\x2\xA5\x32\x3\x2\x2\x2\xA6\xA7\ag\x2\x2\xA7\xA8\an\x2\x2\xA8"+
		"\xA9\au\x2\x2\xA9\xAA\ag\x2\x2\xAA\x34\x3\x2\x2\x2\xAB\xAC\a?\x2\x2\xAC"+
		"\xB5\a?\x2\x2\xAD\xAE\a#\x2\x2\xAE\xB5\a?\x2\x2\xAF\xB0\a>\x2\x2\xB0\xB5"+
		"\a?\x2\x2\xB1\xB2\a@\x2\x2\xB2\xB5\a?\x2\x2\xB3\xB5\t\x3\x2\x2\xB4\xAB"+
		"\x3\x2\x2\x2\xB4\xAD\x3\x2\x2\x2\xB4\xAF\x3\x2\x2\x2\xB4\xB1\x3\x2\x2"+
		"\x2\xB4\xB3\x3\x2\x2\x2\xB5\x36\x3\x2\x2\x2\xB6\xB7\aj\x2\x2\xB7\xB8\a"+
		"\x63\x2\x2\xB8\xB9\ar\x2\x2\xB9\xBA\ar\x2\x2\xBA\xBB\a{\x2\x2\xBB\xBC"+
		"\a\x61\x2\x2\xBC\xBD\au\x2\x2\xBD\xBE\av\x2\x2\xBE\xBF\a\x63\x2\x2\xBF"+
		"\xC0\at\x2\x2\xC0\xC1\av\x2\x2\xC1\x38\x3\x2\x2\x2\xC2\xC3\ao\x2\x2\xC3"+
		"\xC4\a\x63\x2\x2\xC4\xC5\ak\x2\x2\xC5\xC6\ap\x2\x2\xC6\xC7\aU\x2\x2\xC7"+
		"\xC8\ao\x2\x2\xC8\xC9\ak\x2\x2\xC9\xCA\an\x2\x2\xCA\xCB\ag\x2\x2\xCB:"+
		"\x3\x2\x2\x2\xCC\xCD\av\x2\x2\xCD\xCE\at\x2\x2\xCE\xCF\aw\x2\x2\xCF\xD6"+
		"\ag\x2\x2\xD0\xD1\ah\x2\x2\xD1\xD2\a\x63\x2\x2\xD2\xD3\an\x2\x2\xD3\xD4"+
		"\au\x2\x2\xD4\xD6\ag\x2\x2\xD5\xCC\x3\x2\x2\x2\xD5\xD0\x3\x2\x2\x2\xD6"+
		"<\x3\x2\x2\x2\xD7\xD8\a}\x2\x2\xD8\xD9\a<\x2\x2\xD9>\x3\x2\x2\x2\xDA\xDB"+
		"\a<\x2\x2\xDB\xDC\a\x7F\x2\x2\xDC@\x3\x2\x2\x2\xDD\xDF\t\x4\x2\x2\xDE"+
		"\xDD\x3\x2\x2\x2\xDE\xDF\x3\x2\x2\x2\xDF\xE1\x3\x2\x2\x2\xE0\xE2\t\x5"+
		"\x2\x2\xE1\xE0\x3\x2\x2\x2\xE2\xE3\x3\x2\x2\x2\xE3\xE1\x3\x2\x2\x2\xE3"+
		"\xE4\x3\x2\x2\x2\xE4\x42\x3\x2\x2\x2\xE5\xE7\t\x4\x2\x2\xE6\xE5\x3\x2"+
		"\x2\x2\xE6\xE7\x3\x2\x2\x2\xE7\xE9\x3\x2\x2\x2\xE8\xEA\t\x5\x2\x2\xE9"+
		"\xE8\x3\x2\x2\x2\xEA\xEB\x3\x2\x2\x2\xEB\xE9\x3\x2\x2\x2\xEB\xEC\x3\x2"+
		"\x2\x2\xEC\xED\x3\x2\x2\x2\xED\xEF\a\x30\x2\x2\xEE\xF0\t\x5\x2\x2\xEF"+
		"\xEE\x3\x2\x2\x2\xF0\xF1\x3\x2\x2\x2\xF1\xEF\x3\x2\x2\x2\xF1\xF2\x3\x2"+
		"\x2\x2\xF2\x44\x3\x2\x2\x2\xF3\xF5\t\x6\x2\x2\xF4\xF3\x3\x2\x2\x2\xF5"+
		"\xF6\x3\x2\x2\x2\xF6\xF4\x3\x2\x2\x2\xF6\xF7\x3\x2\x2\x2\xF7\xFB\x3\x2"+
		"\x2\x2\xF8\xFA\t\a\x2\x2\xF9\xF8\x3\x2\x2\x2\xFA\xFD\x3\x2\x2\x2\xFB\xF9"+
		"\x3\x2\x2\x2\xFB\xFC\x3\x2\x2\x2\xFC\x46\x3\x2\x2\x2\xFD\xFB\x3\x2\x2"+
		"\x2\xFE\x100\t\b\x2\x2\xFF\xFE\x3\x2\x2\x2\x100\x101\x3\x2\x2\x2\x101"+
		"\xFF\x3\x2\x2\x2\x101\x102\x3\x2\x2\x2\x102\x103\x3\x2\x2\x2\x103\x104"+
		"\b$\x3\x2\x104H\x3\x2\x2\x2\xF\x2m|\xB4\xD5\xDE\xE3\xE6\xEB\xF1\xF6\xFB"+
		"\x101\x4\b\x2\x2\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Happy_language