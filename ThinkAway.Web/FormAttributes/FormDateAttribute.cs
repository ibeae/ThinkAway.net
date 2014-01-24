#region License
//=============================================================================
// ThinkAway MVC - .NET Web Application Framework 
//
// Copyright (c) 2003-2009 Philippe Leybaert
//
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights 
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//=============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using ThinkAway.Web.Controls;

namespace ThinkAway.Web
{
	public class FormDateAttribute : FormTextBoxAttribute
	{
		public DateTime MinDate = DateTime.MinValue;
		public DateTime MaxDate = DateTime.MaxValue;

	    public string DateFormatString = "dd.MM.yyyy";

	    protected internal override bool IsRightType()
		{
			return FieldType == typeof(DateTime) || FieldType == typeof(DateTime?);
		}

		private object NullDate
		{
			get
			{
				if (FieldType == typeof(DateTime?))
					return null;
				else
					return DateTime.MinValue;
			}
		}

	    protected internal override bool Validate(Control control)
		{
	        DateTime? value = (DateTime?) GetControlValue(control);

			if (value == null)
				return true;


			return (value.Value >= MinDate && value.Value <= MaxDate);
		}

	    protected internal override object GetControlValue(Control control)
	    {
            string stringValue = ((TextBoxControl)control).Value;

	        DateTime date;

            if (DateTime.TryParseExact(stringValue, DateFormatString, null, DateTimeStyles.None, out date))
                return date;
            else
                return NullDate;
	    }

        protected internal override void SetControlValue(Control control, object value)
        {
            string stringValue = (value == null || (DateTime)value == DateTime.MinValue) ? "" : ((DateTime) value).ToString(DateFormatString);

            base.SetControlValue(control, stringValue);
        }

	}
}