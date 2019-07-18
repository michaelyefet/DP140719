using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX01
{
    class WinState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            Console.WriteLine("Got Hit but you already won");
            return new WinState();
        }

        public override GameState LevelUp(GameStatus status)
        {
            Console.WriteLine("Got Level up but you already won");
            return new WinState();
        }
    }
}