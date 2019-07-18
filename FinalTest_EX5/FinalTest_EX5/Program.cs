using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHandlerBase infoHandler = new InfoHandler();
            LogHandlerBase errorHandler = new ErrorHandler();
            LogHandlerBase fatalHandler = new FatalHandler();


            LogHandlerBase chainRoot = infoHandler;
            infoHandler.SetNext(errorHandler);
            errorHandler.SetNext(fatalHandler);

            Console.WriteLine("error msg error log", 2);
            chainRoot.Handle("error msg error log", 2);
            Console.WriteLine();
            Console.WriteLine("Info msg Info log", 3);
            chainRoot.Handle("Info msg Info log", 3);
            Console.WriteLine();
            Console.WriteLine("fatal msg fatal log", 1);
            chainRoot.Handle("fatal msg fatal log", 1);
            Console.WriteLine();
        }
    }
}
