using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX01
{
    class NewState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            int currLivingPoints = status.GetLivingPoints() - points;
            status.SetLivingPoints(currLivingPoints);
            if(currLivingPoints < 10)
            {
                Console.WriteLine($"You have {currLivingPoints} living points - you move to danger state");
                return new DangerState();
            }
            else if (currLivingPoints <= 0 )
            {
                Console.WriteLine("You have no living points - sorry you have lost");
                return new LoseState();
            }
            else
            {
                Console.WriteLine($"You have { currLivingPoints} living points");
                return new NewState();
            }
        }

        public override GameState LevelUp(GameStatus status)
        {
            int Level = status.GetCurrentLevel() + 1;
            status.SetCurrentLevel(Level);
            if(Level==4)
            {
                Console.WriteLine("You Have won the game");
                return new WinState();
            }
            else
            {
                Console.WriteLine($"You Got Level up - your level is {Level}");
                return new NewState();
            }
        }
    }
}
