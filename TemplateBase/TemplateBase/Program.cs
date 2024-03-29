﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBase
{
    class Program
    {
        static void Main(string[] args)
        {
            new OracleSelectAllQuery().Run();

            Console.WriteLine();

            new OracleUpdateQuery().Run();

            Console.WriteLine();

            new MongoSelectQuery().Run();

            Console.WriteLine();

            new MongoUpdateQuery().Run();

            Console.WriteLine();

            new MongoDeleteQuery().Run();

            Console.WriteLine();
        }
    }
}
