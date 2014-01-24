﻿//
// Copyright (c) 2008-2011, Kenneth Bell
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
//

namespace ThinkAway.Net.Dns
{
    /// <summary>
    /// Enumeration of known DNS record classes (CLASS in DNS).
    /// </summary>
    public enum RecordClass : int
    {
        /// <summary>
        /// No class defined.
        /// </summary>
        None = 0,

        /// <summary>
        /// The Internet class.
        /// </summary>
        Internet = 1,

        /// <summary>
        /// The CSNET class.
        /// </summary>
        CSNet = 2,

        /// <summary>
        /// The CHAOS network class.
        /// </summary>
        Chaos = 3,

        /// <summary>
        /// The Hesiod class.
        /// </summary>
        Hesiod = 4,

        /// <summary>
        /// Wildcard that matches any class.
        /// </summary>
        Any = 255,
    }
}