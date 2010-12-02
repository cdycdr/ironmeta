﻿//////////////////////////////////////////////////////////////////////
// $Id: Matcher.cs 125 2010-11-10 23:45:07Z kulibali $
//
// Copyright (C) 2009-2010, The IronMeta Project
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
//     * Redistributions of source code must retain the above 
//       copyright notice, this list of conditions and the following 
//       disclaimer.
//     * Redistributions in binary form must reproduce the above 
//       copyright notice, this list of conditions and the following 
//       disclaimer in the documentation and/or other materials 
//       provided with the distribution.
//     * Neither the name of the IronMeta Project nor the names of its 
//       contributors may be used to endorse or promote products 
//       derived from this software without specific prior written 
//       permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND  ANY EXPRESS OR  IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE  IMPLIED WARRANTIES OF  MERCHANTABILITY AND FITNESS 
// FOR  A  PARTICULAR  PURPOSE  ARE DISCLAIMED. IN  NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT  LIMITED TO, PROCUREMENT  OF SUBSTITUTE  GOODS  OR SERVICES; 
// LOSS OF USE, DATA, OR  PROFITS; OR  BUSINESS  INTERRUPTION) HOWEVER 
// CAUSED AND ON ANY THEORY OF  LIABILITY, WHETHER IN CONTRACT, STRICT 
// LIABILITY, OR  TORT (INCLUDING NEGLIGENCE  OR OTHERWISE) ARISING IN 
// ANY WAY OUT  OF THE  USE OF THIS SOFTWARE, EVEN  IF ADVISED  OF THE 
// POSSIBILITY OF SUCH DAMAGE.
//
//////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Linq;

namespace IronMeta.Matcher
{

    /// <summary>
    /// A matcher class for operating on streams of characters.  Provides some utilities for line numbers.
    /// </summary>
    /// <typeparam name="TResult">Result type.</typeparam>
    /// <typeparam name="TItem">Item type (internal).</typeparam>
    public abstract class CharMatcher<TResult, TItem> : Matcher<char, TResult, TItem>
        where TItem : MatchItem<char, TResult, TItem>, new()
    {

        List<int> _line_begins = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="input">Input stream.</param>
        public CharMatcher(IEnumerable<char> input)
            : base(input)
        {
        }

        /// <summary>
        /// Gets the line containing a particular index in the input.
        /// </summary>
        /// <param name="pos">The index in the input.</param>
        /// <param name="offset">The offset of the position after the beginning of the line.</param>
        /// <returns>The line containing a particular input index.</returns>
        public string GetLine(int pos, out int offset)
        {
            offset = 0;

            int index = GetLineNumber(pos) - 1;
            int start = _line_begins[index];
            offset = pos - start;

            int len = index + 1 < _line_begins.Count ? _line_begins[index + 1] - _line_begins[index] : _line_begins.Count - _line_begins[index];

            if (_input_string != null)
            {
                return _input_string.Substring(start, len);
            }
            else
            {
                IEnumerable<char> result = _input_enumerable.Skip(start).Take(len).Cast<char>();
                return new string(result.ToArray());
            }
        }

        /// <summary>
        /// Gets the line number of the line that contains a particular index in the input.
        /// </summary>
        /// <param name="pos">The index in the input.</param>
        /// <returns>The number of the line that contains the index.</returns>
        public int GetLineNumber(int pos)
        {
            if (_line_begins == null)
                MakeLines();

            int low = 0, high = _line_begins.Count - 1;
            int index = low + (high - low) / 2;
            while (_line_begins[index] != pos && low < high)
            {
                if (_line_begins[index] > pos)
                    high = index - 1;
                else
                    low = index + 1;
                index = low + (high - low) / 2;
            }

            return index > 0 ? index : 1;
        }

        /// <summary>
        /// Finds line endings.
        /// </summary>
        private void MakeLines()
        {
            _line_begins = new List<int>();
            _line_begins.Add(0);

            bool found_return = false;
            bool in_end = false;

            if (_input_string != null)
            {
                for (int index = 0; index < _input_string.Length; ++index)
                {
                    char ch = _input_string[index];

                    if (ch == '\r')
                    {
                        found_return = true;
                        in_end = true;
                    }
                    else if (ch == '\n' && !found_return)
                    {
                        found_return = false;
                        in_end = true;
                    }
                    else
                    {
                        found_return = false;
                        if (in_end)
                        {
                            _line_begins.Add(index);
                            in_end = false;
                        }
                    }
                }
            }
            else
            {
                int index = 0;
                foreach (char ch in _input_enumerable)
                {
                    if (ch == '\r')
                    {
                        found_return = true;
                        in_end = true;
                    }
                    else if (ch == '\n' || !found_return)
                    {
                        found_return = false;
                        in_end = true;
                    }
                    else
                    {
                        found_return = false;
                        if (in_end)
                        {
                            _line_begins.Add(index);
                            in_end = false;
                        }
                    }

                    ++index;
                }
            }
        }

    }  // class CharMatcher

} // namespace IronMeta.Matcher