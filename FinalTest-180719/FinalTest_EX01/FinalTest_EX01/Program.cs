using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextGame ctxGameLose = new ContextGame();
            ctxGameLose.LevelUp();
            ctxGameLose.gotHit(15);
            ctxGameLose.gotHit(30);
            ctxGameLose.gotHit(20);
            ctxGameLose.LevelUp();

            ContextGame ctxGameWin = new ContextGame();
            ctxGameWin.LevelUp();
            ctxGameWin.gotHit(23);
            ctxGameWin.LevelUp();
            ctxGameWin.LevelUp();
            ctxGameWin.LevelUp();
            ctxGameWin.LevelUp();
            ctxGameWin.gotHit(300);

        }
    }
}
