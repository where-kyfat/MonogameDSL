// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-KDBR5P2
// DateTime: 10.06.2021 18:41:45
// UserName: User
// Input file <../../YaccLex/SimpleYacc.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using GameLangParser.Nodes;

namespace GameLangParser
{
public enum Tokens {
    error=1,EOF=2,BLOCKBEGIN=3,BLOCKEND=4,SEMICOLON=5,OPBRACKET=6,
    CLBRACKET=7,VAR=8,COMMA=9,OPPARENTHESES=10,CLPARENTHESES=11,ASSIGN=12,
    CODEBLOCK=13,BLOCKSPRITESINIT=14,BLOCKVARIBLESINIT=15,BLOCKLOADCONTENT=16,BLOCKINITIALIZE=17,BLOCKUPDATE=18,
    ID=19,BEHAVIOUR=20};

public struct ValueType
{ 
			public string sVal;

			public SpritesInitNode spsIVal;
			public SpriteInitNode spIVal;
			public List<SpriteInitNode> lstSIVal;
			public List<Type> lstBVal;
			public Type typeVal;

			public VariablesInitNode vInitVal;
			public InitializeNode initVal;
			public UpdateNode upVal;
			public LoadContentNode lConVal;
       }
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from ../../YaccLex/SimpleYacc.y
	public GameNode root;

    public Parser(AbstractScanner<ValueType, LexLocation> scanner, string patternGame) : base(scanner) 
	{
		this.root = new GameNode(patternGame);
	}
  // End verbatim content from ../../YaccLex/SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[14];
  private static State[] states = new State[39];
  private static string[] nonTerms = new string[] {
      "blockSpritesInit", "spriteInit", "spritesInit", "behaviours", "blockVariablesInit", 
      "blockLoadContent", "blockInitialize", "blockUpdate", "funtionality", "progr", 
      "$accept", };

  static Parser() {
    states[0] = new State(new int[]{14,25},new int[]{-10,1,-1,3});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{15,21},new int[]{-5,4});
    states[4] = new State(new int[]{17,17},new int[]{-7,5});
    states[5] = new State(new int[]{16,13},new int[]{-6,6});
    states[6] = new State(new int[]{18,8},new int[]{-8,7});
    states[7] = new State(-2);
    states[8] = new State(new int[]{3,9});
    states[9] = new State(new int[]{13,12},new int[]{-9,10});
    states[10] = new State(new int[]{4,11});
    states[11] = new State(-12);
    states[12] = new State(-13);
    states[13] = new State(new int[]{3,14});
    states[14] = new State(new int[]{13,12},new int[]{-9,15});
    states[15] = new State(new int[]{4,16});
    states[16] = new State(-10);
    states[17] = new State(new int[]{3,18});
    states[18] = new State(new int[]{13,12},new int[]{-9,19});
    states[19] = new State(new int[]{4,20});
    states[20] = new State(-11);
    states[21] = new State(new int[]{3,22});
    states[22] = new State(new int[]{13,12},new int[]{-9,23});
    states[23] = new State(new int[]{4,24});
    states[24] = new State(-9);
    states[25] = new State(new int[]{3,26});
    states[26] = new State(new int[]{19,30},new int[]{-3,27,-2,38});
    states[27] = new State(new int[]{4,28,19,30},new int[]{-2,29});
    states[28] = new State(-3);
    states[29] = new State(-5);
    states[30] = new State(new int[]{12,31});
    states[31] = new State(new int[]{10,32});
    states[32] = new State(new int[]{20,37},new int[]{-4,33});
    states[33] = new State(new int[]{11,34,9,35});
    states[34] = new State(-6);
    states[35] = new State(new int[]{20,36});
    states[36] = new State(-8);
    states[37] = new State(-7);
    states[38] = new State(-4);

    rules[1] = new Rule(-11, new int[]{-10,2});
    rules[2] = new Rule(-10, new int[]{-1,-5,-7,-6,-8});
    rules[3] = new Rule(-1, new int[]{14,3,-3,4});
    rules[4] = new Rule(-3, new int[]{-2});
    rules[5] = new Rule(-3, new int[]{-3,-2});
    rules[6] = new Rule(-2, new int[]{19,12,10,-4,11});
    rules[7] = new Rule(-4, new int[]{20});
    rules[8] = new Rule(-4, new int[]{-4,9,20});
    rules[9] = new Rule(-5, new int[]{15,3,-9,4});
    rules[10] = new Rule(-6, new int[]{16,3,-9,4});
    rules[11] = new Rule(-7, new int[]{17,3,-9,4});
    rules[12] = new Rule(-8, new int[]{18,3,-9,4});
    rules[13] = new Rule(-9, new int[]{13});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // progr -> blockSpritesInit, blockVariablesInit, blockInitialize, 
              //          blockLoadContent, blockUpdate
{ root.AddNode(ValueStack[ValueStack.Depth-5].spsIVal); root.AddNode(ValueStack[ValueStack.Depth-4].vInitVal); root.AddNode(ValueStack[ValueStack.Depth-3].initVal); root.AddNode(ValueStack[ValueStack.Depth-2].lConVal); root.AddNode(ValueStack[ValueStack.Depth-1].upVal);}
        break;
      case 3: // blockSpritesInit -> BLOCKSPRITESINIT, BLOCKBEGIN, spritesInit, BLOCKEND
{ 
						CurrentSemanticValue.spsIVal = new SpritesInitNode(null, ValueStack[ValueStack.Depth-4].sVal);
						CurrentSemanticValue.spsIVal.inits = ValueStack[ValueStack.Depth-2].lstSIVal;
					}
        break;
      case 4: // spritesInit -> spriteInit
{
				CurrentSemanticValue.lstSIVal = new List<SpriteInitNode>();
				CurrentSemanticValue.lstSIVal.Add(ValueStack[ValueStack.Depth-1].spIVal);
			}
        break;
      case 5: // spritesInit -> spritesInit, spriteInit
{
				ValueStack[ValueStack.Depth-2].lstSIVal.Add(ValueStack[ValueStack.Depth-1].spIVal);
				CurrentSemanticValue.lstSIVal = ValueStack[ValueStack.Depth-2].lstSIVal;
			}
        break;
      case 6: // spriteInit -> ID, ASSIGN, OPPARENTHESES, behaviours, CLPARENTHESES
{
				CurrentSemanticValue.spIVal = new SpriteInitNode(ValueStack[ValueStack.Depth-5].sVal);
				CurrentSemanticValue.spIVal.behaviours = ValueStack[ValueStack.Depth-2].lstBVal;
			}
        break;
      case 7: // behaviours -> BEHAVIOUR
{
				CurrentSemanticValue.lstBVal = new List<Type>();
				CurrentSemanticValue.lstBVal.Add(ValueStack[ValueStack.Depth-1].typeVal);
			}
        break;
      case 8: // behaviours -> behaviours, COMMA, BEHAVIOUR
{
				ValueStack[ValueStack.Depth-3].lstBVal.Add(ValueStack[ValueStack.Depth-1].typeVal);
				CurrentSemanticValue.lstBVal = ValueStack[ValueStack.Depth-3].lstBVal;
			}
        break;
      case 9: // blockVariablesInit -> BLOCKVARIBLESINIT, BLOCKBEGIN, funtionality, BLOCKEND
{ CurrentSemanticValue.vInitVal = new VariablesInitNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-4].sVal); }
        break;
      case 10: // blockLoadContent -> BLOCKLOADCONTENT, BLOCKBEGIN, funtionality, BLOCKEND
{ CurrentSemanticValue.lConVal = new LoadContentNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-4].sVal); }
        break;
      case 11: // blockInitialize -> BLOCKINITIALIZE, BLOCKBEGIN, funtionality, BLOCKEND
{ CurrentSemanticValue.initVal = new InitializeNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-4].sVal); }
        break;
      case 12: // blockUpdate -> BLOCKUPDATE, BLOCKBEGIN, funtionality, BLOCKEND
{ CurrentSemanticValue.upVal = new UpdateNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-4].sVal);}
        break;
      case 13: // funtionality -> CODEBLOCK
{ CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal; }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
