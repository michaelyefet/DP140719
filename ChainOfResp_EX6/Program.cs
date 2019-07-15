using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseLogHandler debugLog = new DebugHandler();
            BaseLogHandler infoLog = new InfoHandler();
            BaseLogHandler errorLog = new ErrorHandler();
            BaseLogHandler fatalLog = new FatalHandler();

            BaseLogHandler chainRoot = debugLog;

            debugLog.SetNext(infoLog);
            infoLog.SetNext(errorLog);
            errorLog.SetNext(fatalLog);

            chainRoot.Log("Debug msg", 4);
            Console.WriteLine("==================");
            chainRoot.Log("Info msg", 3);
            Console.WriteLine("==================");
            chainRoot.Log("Error msg", 2);
            Console.WriteLine("==================");
            chainRoot.Log("Fatal msg", 1);

            //Build revers chain
            
            BaseLogHandler reverseDebugLog = new DebugHandler();
            BaseLogHandler reverseInfoLog = new InfoHandler();
            BaseLogHandler reverseErrorLog = new ErrorHandler();
            BaseLogHandler reverseFatalLog = new FatalHandler();

            BaseLogHandler reverseChainRoot = reverseFatalLog;
            reverseFatalLog.SetNext(reverseErrorLog);
            reverseErrorLog.SetNext(reverseInfoLog);
            reverseInfoLog.SetNext(reverseDebugLog);

            Console.WriteLine("second chain");
            chainRoot.Log("Debug msg", 4);
            Console.WriteLine("==================");
            chainRoot.Log("Info msg", 3);
            Console.WriteLine("==================");
            chainRoot.Log("Error msg", 2);
            Console.WriteLine("==================");
            chainRoot.Log("Fatal msg", 1);
        }
    }
}
