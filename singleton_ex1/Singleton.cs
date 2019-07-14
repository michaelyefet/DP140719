﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_ex1
{
    class Singleton
    {
        private static Singleton INSTANCE;

        private static object key = new object();
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (INSTANCE != null)
            {
                return INSTANCE;
            }

            lock (key)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Singleton();
                }
            }

            return INSTANCE;
        }

        public void printTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
