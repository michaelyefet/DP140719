﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX10
{
    public class BaseWindow : IWindow
    {
        public string GetDetails()
        {
            return "A basic window";
        }
    }
}
