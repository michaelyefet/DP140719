using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX5
{
    public class FatalHandler : LogHandlerBase
    {
        protected const string ERROR_FILE_PATH = @"C:\Users\HackerU\source\Exam\MichaelErrorLog\log.txt";
        private const int LEVEL = 1;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("FATAL: " + log);
                WriteToFile(log);
            }
            else if (nextHandelr != null)
            {
                nextHandelr.Handle(log, level);
            }
        }

        private void WriteToFile(string log)
        {
            Console.WriteLine("Writing fatal to file...");
            File.AppendAllText(ERROR_FILE_PATH, Environment.NewLine + "FATAL: " + log);
        }
    }
}
