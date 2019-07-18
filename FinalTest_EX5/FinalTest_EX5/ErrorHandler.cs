using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX5
{
    class ErrorHandler : LogHandlerBase
    {
        protected const string ERROR_FILE_PATH = @"C:\Users\HackerU\source\Exam\MichaelErrorLog\log.txt";
        protected const int LEVEL = 2;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("ERROR: " + log);
                WriteToFile(log);

            }
            else if (nextHandelr != null)
            {
                nextHandelr.Handle(log, level);
            }
        }

        private void WriteToFile(string log)
        {
            Console.WriteLine("Writing error to file...");
            File.AppendAllText(ERROR_FILE_PATH, Environment.NewLine + "ERROR: " + log);
        }
    }
}
