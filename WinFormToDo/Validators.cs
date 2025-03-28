﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToDo
{
    public static class Validators
    {

        public static bool IsEmptyText(Control control)
        {
            return control.Text == "";
        }

        public static bool IsTextNull(Control control)
        {
            return control.Text == null;
        }

        public static bool IsMinLength(Control control, int minLength)
        {
            return control.Text.Length >= minLength;
        }

        public static bool IsValidDate(Control control)
        {
            DateTime Temp = DateTime.Now;
            return DateTime.TryParse(control.Text, out Temp);
        }
    }
}
