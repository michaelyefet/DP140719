using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX4
{
    class Locked : LoginBase
    {
        public Locked(ContextLogin ctx) : base(ctx)
        {
        }
        public override void Newlogin(string PasswardTry)
        {
            Console.WriteLine("You are locked.. if you want to login try activate restart");
        }

        public override void Restart()
        {
            ctx.State = new NewLogin(ctx);
            Console.WriteLine("you are now at new login state");
        }
    }
}
