﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX01
{
    class LoseState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            Console.WriteLine("Got Hit but you already lost");
            return new LoseState();
        }

        public override GameState LevelUp(GameStatus status)
        {
            Console.WriteLine("Got Level up but already lost");
            return new LoseState();
        }
    }
}
