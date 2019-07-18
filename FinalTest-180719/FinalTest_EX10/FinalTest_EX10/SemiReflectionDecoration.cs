﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX10
{
    public class SemiReflectionDecoration : WindowDecoratorBase
    {
        public SemiReflectionDecoration(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + "with semi reflection";
        }
    }
}