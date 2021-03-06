//
// IronMeta MatcherTestsParser Parser; Generated 2016-03-30 04:29:19Z UTC
//

using System;
using System.Collections.Generic;
using System.Linq;

using IronMeta.Matcher;

#pragma warning disable 0219
#pragma warning disable 1591

namespace IronMeta.UnitTests.Matcher
{

    using _MatcherTestsParser_Inputs = IEnumerable<char>;
    using _MatcherTestsParser_Results = IEnumerable<int>;
    using _MatcherTestsParser_Item = IronMeta.Matcher.MatchItem<char, int>;
    using _MatcherTestsParser_Args = IEnumerable<IronMeta.Matcher.MatchItem<char, int>>;
    using _MatcherTestsParser_Memo = IronMeta.Matcher.MatchState<char, int>;
    using _MatcherTestsParser_Rule = System.Action<IronMeta.Matcher.MatchState<char, int>, int, IEnumerable<IronMeta.Matcher.MatchItem<char, int>>>;
    using _MatcherTestsParser_Base = IronMeta.Matcher.Matcher<char, int>;

    public partial class MatcherTestsParser : Matcher<char, int>
    {
        public MatcherTestsParser()
            : base()
        {
            _setTerminals();
        }

        public MatcherTestsParser(bool handle_left_recursion)
            : base(handle_left_recursion)
        {
            _setTerminals();
        }

        void _setTerminals()
        {
            this.Terminals = new HashSet<string>()
            {
                "Action",
                "AndLiteral",
                "AndString",
                "Any",
                "Call1",
                "Call2",
                "Call3",
                "Call4",
                "Call5",
                "Call6",
                "Call7",
                "CallAct",
                "CallAct2",
                "CallAnd",
                "CallAnd2",
                "CallAny",
                "CallAny2",
                "CallCallRule",
                "CallCallVar",
                "CallCallVar2",
                "CallClass",
                "CallCond",
                "CallCond2",
                "CallFail",
                "CallLook",
                "CallNot",
                "CallNot2",
                "CallOr",
                "CallOr2",
                "CallOr3",
                "CallPlus",
                "CallPlus2",
                "CallQues",
                "CallQues2",
                "CallStar",
                "CallStar2",
                "Class",
                "Class2",
                "Cond",
                "Cond2",
                "Fail",
                "Literal",
                "LiteralString",
                "Look",
                "Not",
                "OrLiteral",
                "OrString",
                "Plus1",
                "Plus2",
                "Ques",
                "Star1",
                "Star2",
                "SubCall",
                "SubCall2",
                "SubCallAnd",
                "SubCallAny",
                "SubCallClass",
                "SubCallCond",
                "SubCallFail",
                "SubCallLook",
                "SubCallNot",
                "SubCallOr",
                "SubCallPlus",
                "SubCallQues",
                "SubCallStar",
                "SubCallVar",
                "TestBuildTasks",
                "TestCount",
                "TestInputs",
                "TestMinMax1",
                "TestMinMax2",
                "TestReturn",
                "TestReturn1",
                "TestReturn2",
                "TestReturn3",
                "XOrY",
            };
        }


        public void Literal(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        }


        public void LiteralString(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL "abc"
            _ParseLiteralString(_memo, ref _index, "abc");

        }


        public void Class(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // INPUT CLASS
            _ParseInputClass(_memo, ref _index, 'a', 'b', 'c');

        }


        public void Class2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // INPUT CLASS
            _ParseInputClass(_memo, ref _index, '\u0001', '\u0002', '\u0003');

        }


        public void AndLiteral(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void OrLiteral(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void AndString(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // LITERAL "ab"
            _ParseLiteralString(_memo, ref _index, "ab");

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL "cd"
            _ParseLiteralString(_memo, ref _index, "cd");

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void OrString(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // LITERAL "ab"
            _ParseLiteralString(_memo, ref _index, "ab");

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL "cd"
            _ParseLiteralString(_memo, ref _index, "cd");

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void Fail(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // FAIL
            _memo.Results.Push(null);
            _memo.ClearErrors();
            _memo.AddError(_index, () => "This is a fail.");

        }


        public void Any(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ANY
            _ParseAny(_memo, ref _index);

        }


        public void Look(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LOOK 3
            int _start_i3 = _index;

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

            // LOOK 3
            var _r3 = _memo.Results.Pop();
            _memo.Results.Push( _r3 != null ? new _MatcherTestsParser_Item(_start_i3, _memo.InputEnumerable) : null );
            _index = _start_i3;

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL "bc"
            _ParseLiteralString(_memo, ref _index, "bc");

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Not(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // NOT 3
            int _start_i3 = _index;

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

            // NOT 3
            var _r3 = _memo.Results.Pop();
            _memo.Results.Push( _r3 == null ? new _MatcherTestsParser_Item(_start_i3, _memo.InputEnumerable) : null);
            _index = _start_i3;

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Star1(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // STAR 2
            int _start_i2 = _index;
            var _res2 = Enumerable.Empty<int>();
        label2:

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

            // STAR 2
            var _r2 = _memo.Results.Pop();
            if (_r2 != null)
            {
                _res2 = _res2.Concat(_r2.Results);
                goto label2;
            }
            else
            {
                _memo.Results.Push(new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _res2.Where(_NON_NULL), true));
            }

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Star2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // STAR 3
            int _start_i3 = _index;
            var _res3 = Enumerable.Empty<int>();
        label3:

            // AND 4
            int _start_i4 = _index;

            // NOT 5
            int _start_i5 = _index;

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

            // NOT 5
            var _r5 = _memo.Results.Pop();
            _memo.Results.Push( _r5 == null ? new _MatcherTestsParser_Item(_start_i5, _memo.InputEnumerable) : null);
            _index = _start_i5;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // ANY
            _ParseAny(_memo, ref _index);

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // STAR 3
            var _r3 = _memo.Results.Pop();
            if (_r3 != null)
            {
                _res3 = _res3.Concat(_r3.Results);
                goto label3;
            }
            else
            {
                _memo.Results.Push(new _MatcherTestsParser_Item(_start_i3, _index, _memo.InputEnumerable, _res3.Where(_NON_NULL), true));
            }

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Plus1(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // PLUS 2
            int _start_i2 = _index;
            var _res2 = Enumerable.Empty<int>();
        label2:

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

            // PLUS 2
            var _r2 = _memo.Results.Pop();
            if (_r2 != null)
            {
                _res2 = _res2.Concat(_r2.Results);
                goto label2;
            }
            else
            {
                if (_index > _start_i2)
                    _memo.Results.Push(new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _res2.Where(_NON_NULL), true));
                else
                    _memo.Results.Push(null);
            }

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Plus2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // PLUS 3
            int _start_i3 = _index;
            var _res3 = Enumerable.Empty<int>();
        label3:

            // AND 4
            int _start_i4 = _index;

            // NOT 5
            int _start_i5 = _index;

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

            // NOT 5
            var _r5 = _memo.Results.Pop();
            _memo.Results.Push( _r5 == null ? new _MatcherTestsParser_Item(_start_i5, _memo.InputEnumerable) : null);
            _index = _start_i5;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // ANY
            _ParseAny(_memo, ref _index);

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // PLUS 3
            var _r3 = _memo.Results.Pop();
            if (_r3 != null)
            {
                _res3 = _res3.Concat(_r3.Results);
                goto label3;
            }
            else
            {
                if (_index > _start_i3)
                    _memo.Results.Push(new _MatcherTestsParser_Item(_start_i3, _index, _memo.InputEnumerable, _res3.Where(_NON_NULL), true));
                else
                    _memo.Results.Push(null);
            }

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Ques(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _MatcherTestsParser_Item(_index, _memo.InputEnumerable)); }

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Cond(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _MatcherTestsParser_Item c = null;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // COND 3
            int _start_i3 = _index;

            // ANY
            _ParseAny(_memo, ref _index);

            // BIND c
            c = _memo.Results.Peek();

            // COND
            if (_memo.Results.Peek() == null || !((char)c == 'b')) { _memo.Results.Pop(); _memo.Results.Push(null); _index = _start_i3; }

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Cond2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // COND 3
            int _start_i3 = _index;

            // ANY
            _ParseAny(_memo, ref _index);

            // COND
            Func<_MatcherTestsParser_Item, bool> lambda3 = (_IM_Result) => { return (char)_IM_Result == 'b'; };
            if (_memo.Results.Peek() == null || !lambda3(_memo.Results.Peek())) { _memo.Results.Pop(); _memo.Results.Push(null); _index = _start_i3; }

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Action(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

            // ACT
            var _r2 = _memo.Results.Peek();
            if (_r2 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _MatcherTestsParser_Item(_r2.StartIndex, _r2.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return 123; }, _r2), true) );
            }

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void Call1(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // CALL AndLiteral
            var _start_i2 = _index;
            _MatcherTestsParser_Item _r2;
            _r2 = _MemoCall(_memo, "AndLiteral", _index, AndLiteral, _args != null ? _args.Skip(_arg_index) : null);

            if (_r2 != null) _index = _r2.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Call2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // CALLORVAR OrLiteral
            _MatcherTestsParser_Item _r3;

            _r3 = _MemoCall(_memo, "OrLiteral", _index, OrLiteral, null);

            if (_r3 != null) _index = _r3.NextIndex;

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void SubCall(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 2
            int _start_i2 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void Call3(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCall
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';
            var _arg0_1 = 'b';
            var _arg0_2 = 'c';
            var _arg0_3 = new System.Char();

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0), new _MatcherTestsParser_Item(_arg0_1), new _MatcherTestsParser_Item(_arg0_2), new _MatcherTestsParser_Item(_arg0_3) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCall", _index, SubCall, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void Call4(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCall
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCall", _index, SubCall, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCall2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // AND 1
            int _start_i1 = _arg_index;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label1; }

            // LITERAL 'b'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'b', _args);

        label1: // AND
            var _r1_2 = _memo.ArgResults.Pop();
            var _r1_1 = _memo.ArgResults.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.ArgResults.Push(new _MatcherTestsParser_Item(_start_i1, _arg_index, _r1_1.Inputs.Concat(_r1_2.Inputs), _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i1;
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 4
            int _start_i4 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void Call5(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCall
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';
            var _arg0_1 = 'b';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0), new _MatcherTestsParser_Item(_arg0_1) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCall", _index, SubCall, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void Call6(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCall
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'z';
            var _arg0_1 = 'w';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0), new _MatcherTestsParser_Item(_arg0_1) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCall", _index, SubCall, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void Call7(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCall
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = "ab";

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCall", _index, SubCall, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallFail(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // FAIL
            _memo.ArgResults.Push(null);

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallFail(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCallFail
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCallFail", _index, SubCallFail, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallClass(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // INPUT CLASS
            _ParseInputClassArgs(_memo, ref _arg_index, ref _arg_input_index, _args, 'a', 'b');

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 2
            int _start_i2 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallClass(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // LOOK 1
            int _start_i1 = _index;

            // CALL SubCallClass
            var _start_i2 = _index;
            _MatcherTestsParser_Item _r2;
            var _arg2_0 = 'a';

            _MatcherTestsParser_Args _actual_args2 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg2_0) };
            if (_args != null) _actual_args2 = _actual_args2.Concat(_args.Skip(_arg_index));
            _r2 = _MemoCall(_memo, "SubCallClass", _index, SubCallClass, _actual_args2);

            if (_r2 != null) _index = _r2.NextIndex;

            // LOOK 1
            var _r1 = _memo.Results.Pop();
            _memo.Results.Push( _r1 != null ? new _MatcherTestsParser_Item(_start_i1, _memo.InputEnumerable) : null );
            _index = _start_i1;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // CALL SubCallClass
            var _start_i3 = _index;
            _MatcherTestsParser_Item _r3;
            var _arg3_0 = 'b';

            _MatcherTestsParser_Args _actual_args3 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg3_0) };
            if (_args != null) _actual_args3 = _actual_args3.Concat(_args.Skip(_arg_index));
            _r3 = _MemoCall(_memo, "SubCallClass", _index, SubCallClass, _actual_args3);

            if (_r3 != null) _index = _r3.NextIndex;

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void SubCallAny(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 2
            int _start_i2 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallAny(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallAny
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallAny", _index, SubCallAny, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallAny2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCallAny
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCallAny", _index, SubCallAny, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallLook(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // AND 1
            int _start_i1 = _arg_index;

            // LOOK 2
            int _start_i2 = _arg_index;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // LOOK 2
            var _r2 = _memo.ArgResults.Pop();
            _memo.ArgResults.Push(_r2);
            _arg_index = _start_i2;

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label1; }

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

        label1: // AND
            var _r1_2 = _memo.ArgResults.Pop();
            var _r1_1 = _memo.ArgResults.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.ArgResults.Push(new _MatcherTestsParser_Item(_start_i1, _arg_index, _r1_1.Inputs.Concat(_r1_2.Inputs), _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i1;
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 5
            int _start_i5 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallLook(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallLook
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallLook", _index, SubCallLook, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallNot(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // AND 1
            int _start_i1 = _arg_index;

            // NOT 2
            int _start_i2 = _arg_index;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // NOT 2
            var _r2 = _memo.ArgResults.Pop();
            _memo.ArgResults.Push(_r2 == null ? new _MatcherTestsParser_Item(_arg_index, _arg_index, _memo.InputEnumerable, Enumerable.Empty<int>(), false) : null);
            _arg_index = _start_i2;

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label1; }

            // LITERAL 'b'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'b', _args);

        label1: // AND
            var _r1_2 = _memo.ArgResults.Pop();
            var _r1_1 = _memo.ArgResults.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.ArgResults.Push(new _MatcherTestsParser_Item(_start_i1, _arg_index, _r1_1.Inputs.Concat(_r1_2.Inputs), _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i1;
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 5
            int _start_i5 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallNot(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallNot
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'b';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallNot", _index, SubCallNot, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallNot2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallNot
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallNot", _index, SubCallNot, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallOr(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // OR 1
            int _start_i1 = _arg_index;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // OR shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Pop(); _arg_index = _start_i1; } else goto label1;

            // LITERAL 'b'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'b', _args);

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 4
            int _start_i4 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallOr(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallOr
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallOr", _index, SubCallOr, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallOr2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallOr
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'b';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallOr", _index, SubCallOr, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallOr3(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallOr
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'c';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallOr", _index, SubCallOr, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallAnd(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // AND 1
            int _start_i1 = _arg_index;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label1; }

            // LITERAL 'b'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'b', _args);

        label1: // AND
            var _r1_2 = _memo.ArgResults.Pop();
            var _r1_1 = _memo.ArgResults.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.ArgResults.Push(new _MatcherTestsParser_Item(_start_i1, _arg_index, _r1_1.Inputs.Concat(_r1_2.Inputs), _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i1;
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 4
            int _start_i4 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallAnd(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallAnd
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';
            var _arg0_1 = 'b';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0), new _MatcherTestsParser_Item(_arg0_1) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallAnd", _index, SubCallAnd, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallAnd2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallAnd
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'w';
            var _arg0_1 = 'z';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0), new _MatcherTestsParser_Item(_arg0_1) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallAnd", _index, SubCallAnd, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallStar(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // STAR 1
            int _start_i1 = _arg_index;
            var _inp1 = Enumerable.Empty<char>();
            var _res1 = Enumerable.Empty<int>();
        label1:

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // STAR 1
            var _r1 = _memo.ArgResults.Pop();
            if (_r1 != null)
            {
                _inp1 = _inp1.Concat(_r1.Inputs);
                _res1 = _res1.Concat(_r1.Results);
                goto label1;
            }
            else
            {
                _memo.ArgResults.Push(new _MatcherTestsParser_Item(_start_i1, _arg_index, _inp1, _res1.Where(_NON_NULL), false));
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 3
            int _start_i3 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallStar(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCallStar
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCallStar", _index, SubCallStar, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallStar2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallStar
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallStar", _index, SubCallStar, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallPlus(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // PLUS 1
            int _start_i1 = _arg_index;
            var _inp1 = Enumerable.Empty<char>();
            var _res1 = Enumerable.Empty<int>();
        label1:

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // PLUS 1
            var _r1 = _memo.ArgResults.Pop();
            if (_r1 != null)
            {
                _inp1 = _inp1.Concat(_r1.Inputs);
                _res1 = _res1.Concat(_r1.Results);
                goto label1;
            }
            else
            {
                if (_arg_index > _start_i1)
                    _memo.ArgResults.Push(new _MatcherTestsParser_Item(_start_i1, _arg_index, _inp1, _res1.Where(_NON_NULL), false));
                else
                    _memo.ArgResults.Push(null);
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 3
            int _start_i3 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallPlus(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallPlus
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallPlus", _index, SubCallPlus, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallPlus2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCallPlus
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCallPlus", _index, SubCallPlus, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallQues(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // QUES
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Pop(); _memo.ArgResults.Push(new _MatcherTestsParser_Item(_arg_index, _memo.InputEnumerable)); }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 3
            int _start_i3 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallQues(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallQues
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallQues", _index, SubCallQues, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallQues2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCallQues
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCallQues", _index, SubCallQues, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallCond(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _MatcherTestsParser_Item v = null;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // COND 1
            int _start_i1 = _arg_index;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND v
            v = _memo.ArgResults.Peek();

            // COND
            if (_memo.ArgResults.Peek() == null || !((char)v == 'a')) { _memo.ArgResults.Pop(); _memo.ArgResults.Push(null); _arg_index = _start_i1; }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 4
            int _start_i4 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallCond(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallCond
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallCond", _index, SubCallCond, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallCond2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCallCond
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCallCond", _index, SubCallCond, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void VarInput(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _MatcherTestsParser_Item a = null;

            // AND 0
            int _start_i0 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // BIND a
            a = _memo.Results.Peek();

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // CALLORVAR a
            _MatcherTestsParser_Item _r3;

            if (a.Production != null)
            {
                var _p3 = (System.Action<_MatcherTestsParser_Memo, int, IEnumerable<_MatcherTestsParser_Item>>)(object)a.Production;
                _r3 = _MemoCall(_memo, a.Production.Method.Name, _index, _p3, _args != null ? _args.Skip(_arg_index) : null);
            }
            else
            {
                _r3 = _ParseLiteralObj(_memo, ref _index, a.Inputs);
            }

            if (_r3 != null) _index = _r3.NextIndex;

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void SubCallAct(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _MatcherTestsParser_Item a = null;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // ACT
            var _r2 = _memo.ArgResults.Peek();
            if (_r2 != null)
            {
                _memo.ArgResults.Pop();
                _memo.ArgResults.Push( new _MatcherTestsParser_Item(_r2.StartIndex, _r2.NextIndex, _r2.Inputs, _Thunk(_IM_Result => { return 42; }, _r2), false) );
            }

            // BIND a
            a = _memo.ArgResults.Peek();

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // CALLORVAR a
            _MatcherTestsParser_Item _r4;

            if (a.Production != null)
            {
                var _p4 = (System.Action<_MatcherTestsParser_Memo, int, IEnumerable<_MatcherTestsParser_Item>>)(object)a.Production;
                _r4 = _MemoCall(_memo, a.Production.Method.Name, _index, _p4, _args != null ? _args.Skip(_arg_index) : null);
            }
            else
            {
                _r4 = _ParseLiteralObj(_memo, ref _index, a.Inputs);
            }

            if (_r4 != null) _index = _r4.NextIndex;

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallAct(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallAct
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = 'a';

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallAct", _index, SubCallAct, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallAct2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCallAct
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCallAct", _index, SubCallAct, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallVar(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _MatcherTestsParser_Item a = null;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // AND 1
            int _start_i1 = _arg_index;

            // LITERAL 'a'
            _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, 'a', _args);

            // BIND a
            a = _memo.ArgResults.Peek();

            // AND shortcut
            if (_memo.ArgResults.Peek() == null) { _memo.ArgResults.Push(null); goto label1; }

            // CALLORVAR a
            var _r4 = _ParseLiteralArgs(_memo, ref _arg_index, ref _arg_input_index, a.Inputs, _args);
            if (_r4 != null) _arg_index = _r4.NextIndex;

        label1: // AND
            var _r1_2 = _memo.ArgResults.Pop();
            var _r1_1 = _memo.ArgResults.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.ArgResults.Push(new _MatcherTestsParser_Item(_start_i1, _arg_index, _r1_1.Inputs.Concat(_r1_2.Inputs), _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), false));
            }
            else
            {
                _memo.ArgResults.Push(null);
                _arg_index = _start_i1;
            }

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 5
            int _start_i5 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label5; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label5: // AND
            var _r5_2 = _memo.Results.Pop();
            var _r5_1 = _memo.Results.Pop();

            if (_r5_1 != null && _r5_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i5, _index, _memo.InputEnumerable, _r5_1.Results.Concat(_r5_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i5;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void CallCallVar(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallVar
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;
            var _arg0_0 = "aa";

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(_arg0_0) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallVar", _index, SubCallVar, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void CallCallVar2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALLORVAR SubCallVar
            _MatcherTestsParser_Item _r0;

            _r0 = _MemoCall(_memo, "SubCallVar", _index, SubCallVar, null);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void SubCallRule(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            _MatcherTestsParser_Item a = null;

            // ARGS 0
            _arg_index = 0;
            _arg_input_index = 0;

            // ANY
            _ParseAnyArgs(_memo, ref _arg_index, ref _arg_input_index, _args);

            // BIND a
            a = _memo.ArgResults.Peek();

            if (_memo.ArgResults.Pop() == null)
            {
                _memo.Results.Push(null);
                goto label0;
            }

            // AND 3
            int _start_i3 = _index;

            // CALLORVAR a
            _MatcherTestsParser_Item _r4;

            if (a.Production != null)
            {
                var _p4 = (System.Action<_MatcherTestsParser_Memo, int, IEnumerable<_MatcherTestsParser_Item>>)(object)a.Production;
                _r4 = _MemoCall(_memo, a.Production.Method.Name, _index, _p4, _args != null ? _args.Skip(_arg_index) : null);
            }
            else
            {
                _r4 = _ParseLiteralObj(_memo, ref _index, a.Inputs);
            }

            if (_r4 != null) _index = _r4.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // CALL a
            var _start_i5 = _index;
            _MatcherTestsParser_Item _r5;
            _r5 = _MemoCall(_memo, a.ProductionName, _index, a.Production, _args != null ? _args.Skip(_arg_index) : null);

            if (_r5 != null) _index = _r5.NextIndex;

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

        label0: // ARGS 0
            _arg_input_index = _arg_index; // no-op for label

        }


        public void XOrY(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void CallCallRule(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // CALL SubCallRule
            var _start_i0 = _index;
            _MatcherTestsParser_Item _r0;

            _MatcherTestsParser_Args _actual_args0 = new _MatcherTestsParser_Item[] { new _MatcherTestsParser_Item(XOrY) };
            if (_args != null) _actual_args0 = _actual_args0.Concat(_args.Skip(_arg_index));
            _r0 = _MemoCall(_memo, "SubCallRule", _index, SubCallRule, _actual_args0);

            if (_r0 != null) _index = _r0.NextIndex;

        }


        public void ChoiceLR(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // CALLORVAR ChoiceA
            _MatcherTestsParser_Item _r2;

            _r2 = _MemoCall(_memo, "ChoiceA", _index, ChoiceA, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // CALLORVAR ChoiceB
            _MatcherTestsParser_Item _r3;

            _r3 = _MemoCall(_memo, "ChoiceB", _index, ChoiceB, null);

            if (_r3 != null) _index = _r3.NextIndex;

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void ChoiceA(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // CALLORVAR ChoiceLR
            _MatcherTestsParser_Item _r1;

            _r1 = _MemoCall(_memo, "ChoiceLR", _index, ChoiceLR, null);

            if (_r1 != null) _index = _r1.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void ChoiceB(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // CALLORVAR ChoiceLR
            _MatcherTestsParser_Item _r1;

            _r1 = _MemoCall(_memo, "ChoiceLR", _index, ChoiceLR, null);

            if (_r1 != null) _index = _r1.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'z'
            _ParseLiteralChar(_memo, ref _index, 'z');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void DirectLR(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // CALLORVAR DirectLR
            _MatcherTestsParser_Item _r2;

            _r2 = _MemoCall(_memo, "DirectLR", _index, DirectLR, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void IndirectLR_A(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // CALLORVAR IndirectLR_B
            _MatcherTestsParser_Item _r2;

            _r2 = _MemoCall(_memo, "IndirectLR_B", _index, IndirectLR_B, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL 'y'
            _ParseLiteralChar(_memo, ref _index, 'y');

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL 'x'
            _ParseLiteralChar(_memo, ref _index, 'x');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void IndirectLR_B(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // CALLORVAR IndirectLR_A
            _MatcherTestsParser_Item _r1;

            _r1 = _MemoCall(_memo, "IndirectLR_A", _index, IndirectLR_A, null);

            if (_r1 != null) _index = _r1.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // LITERAL 'z'
            _ParseLiteralChar(_memo, ref _index, 'z');

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void PathalogicalA(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // CALLORVAR PathalogicalA
            _MatcherTestsParser_Item _r2;

            _r2 = _MemoCall(_memo, "PathalogicalA", _index, PathalogicalA, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // CALLORVAR PathalogicalB
            _MatcherTestsParser_Item _r4;

            _r4 = _MemoCall(_memo, "PathalogicalB", _index, PathalogicalB, null);

            if (_r4 != null) _index = _r4.NextIndex;

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void PathalogicalB(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // CALLORVAR PathalogicalB
            _MatcherTestsParser_Item _r3;

            _r3 = _MemoCall(_memo, "PathalogicalB", _index, PathalogicalB, null);

            if (_r3 != null) _index = _r3.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // CALLORVAR PathalogicalA
            _MatcherTestsParser_Item _r5;

            _r5 = _MemoCall(_memo, "PathalogicalA", _index, PathalogicalA, null);

            if (_r5 != null) _index = _r5.NextIndex;

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // CALLORVAR PathalogicalC
            _MatcherTestsParser_Item _r6;

            _r6 = _MemoCall(_memo, "PathalogicalC", _index, PathalogicalC, null);

            if (_r6 != null) _index = _r6.NextIndex;

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void PathalogicalC(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // CALLORVAR PathalogicalC
            _MatcherTestsParser_Item _r3;

            _r3 = _MemoCall(_memo, "PathalogicalC", _index, PathalogicalC, null);

            if (_r3 != null) _index = _r3.NextIndex;

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // CALLORVAR PathalogicalB
            _MatcherTestsParser_Item _r5;

            _r5 = _MemoCall(_memo, "PathalogicalB", _index, PathalogicalB, null);

            if (_r5 != null) _index = _r5.NextIndex;

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // LITERAL 'd'
            _ParseLiteralChar(_memo, ref _index, 'd');

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void TestBuildTasks(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL "testBuildTask9"
            _ParseLiteralString(_memo, ref _index, "testBuildTask9");

        }


        public void TestInputs(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL 'c'
            _ParseLiteralChar(_memo, ref _index, 'c');

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _MatcherTestsParser_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return ((IEnumerable<char>)_IM_Result.Inputs).SequenceEqual("abc") ? 1 : 0; }, _r0), true) );
            }

        }


        public void TestMinMax1(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _MatcherTestsParser_Item(_index, _memo.InputEnumerable)); }

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // NOT 9
            int _start_i9 = _index;

            // ANY
            _ParseAny(_memo, ref _index);

            // NOT 9
            var _r9 = _memo.Results.Pop();
            _memo.Results.Push( _r9 == null ? new _MatcherTestsParser_Item(_start_i9, _memo.InputEnumerable) : null);
            _index = _start_i9;

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void TestMinMax2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

            // QUES
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _memo.Results.Push(new _MatcherTestsParser_Item(_index, _memo.InputEnumerable)); }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // NOT 3
            int _start_i3 = _index;

            // ANY
            _ParseAny(_memo, ref _index);

            // NOT 3
            var _r3 = _memo.Results.Pop();
            _memo.Results.Push( _r3 == null ? new _MatcherTestsParser_Item(_start_i3, _memo.InputEnumerable) : null);
            _index = _start_i3;

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void TestReturn(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // OR 0
            int _start_i0 = _index;

            // OR 1
            int _start_i1 = _index;

            // CALLORVAR TestReturn1
            _MatcherTestsParser_Item _r2;

            _r2 = _MemoCall(_memo, "TestReturn1", _index, TestReturn1, null);

            if (_r2 != null) _index = _r2.NextIndex;

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i1; } else goto label1;

            // CALLORVAR TestReturn2
            _MatcherTestsParser_Item _r3;

            _r3 = _MemoCall(_memo, "TestReturn2", _index, TestReturn2, null);

            if (_r3 != null) _index = _r3.NextIndex;

        label1: // OR
            int _dummy_i1 = _index; // no-op for label

            // OR shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Pop(); _index = _start_i0; } else goto label0;

            // CALLORVAR TestReturn3
            _MatcherTestsParser_Item _r4;

            _r4 = _MemoCall(_memo, "TestReturn3", _index, TestReturn3, null);

            if (_r4 != null) _index = _r4.NextIndex;

        label0: // OR
            int _dummy_i0 = _index; // no-op for label

        }


        public void TestReturn1(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL "a"
            _ParseLiteralString(_memo, ref _index, "a");

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _MatcherTestsParser_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return new List<int> { 1, 2, 3}; }, _r0), true) );
            }

        }


        public void TestReturn2(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL "b"
            _ParseLiteralString(_memo, ref _index, "b");

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _MatcherTestsParser_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return new List<int> { 4, 5, 6}; }, _r0), true) );
            }

        }


        public void TestReturn3(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // LITERAL "c"
            _ParseLiteralString(_memo, ref _index, "c");

            // ACT
            var _r0 = _memo.Results.Peek();
            if (_r0 != null)
            {
                _memo.Results.Pop();
                _memo.Results.Push( new _MatcherTestsParser_Item(_r0.StartIndex, _r0.NextIndex, _memo.InputEnumerable, _Thunk(_IM_Result => { return new List<int> { 7, 8, 9}; }, _r0), true) );
            }

        }


        public void TestCount(_MatcherTestsParser_Memo _memo, int _index, _MatcherTestsParser_Args _args)
        {

            int _arg_index = 0;
            int _arg_input_index = 0;

            // AND 0
            int _start_i0 = _index;

            // AND 1
            int _start_i1 = _index;

            // AND 2
            int _start_i2 = _index;

            // AND 3
            int _start_i3 = _index;

            // AND 4
            int _start_i4 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label4; }

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        label4: // AND
            var _r4_2 = _memo.Results.Pop();
            var _r4_1 = _memo.Results.Pop();

            if (_r4_1 != null && _r4_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i4, _index, _memo.InputEnumerable, _r4_1.Results.Concat(_r4_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i4;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label3; }

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        label3: // AND
            var _r3_2 = _memo.Results.Pop();
            var _r3_1 = _memo.Results.Pop();

            if (_r3_1 != null && _r3_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i3, _index, _memo.InputEnumerable, _r3_1.Results.Concat(_r3_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i3;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label2; }

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

        label2: // AND
            var _r2_2 = _memo.Results.Pop();
            var _r2_1 = _memo.Results.Pop();

            if (_r2_1 != null && _r2_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i2, _index, _memo.InputEnumerable, _r2_1.Results.Concat(_r2_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i2;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label1; }

            // LITERAL 'b'
            _ParseLiteralChar(_memo, ref _index, 'b');

        label1: // AND
            var _r1_2 = _memo.Results.Pop();
            var _r1_1 = _memo.Results.Pop();

            if (_r1_1 != null && _r1_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i1, _index, _memo.InputEnumerable, _r1_1.Results.Concat(_r1_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i1;
            }

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // NOT 10
            int _start_i10 = _index;

            // ANY
            _ParseAny(_memo, ref _index);

            // NOT 10
            var _r10 = _memo.Results.Pop();
            _memo.Results.Push( _r10 == null ? new _MatcherTestsParser_Item(_start_i10, _memo.InputEnumerable) : null);
            _index = _start_i10;

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _MatcherTestsParser_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


    } // class MatcherTestsParser

} // namespace IronMeta.UnitTests.Matcher

