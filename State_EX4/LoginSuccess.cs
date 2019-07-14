using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX4
{
    class LoginSuccess : LoginBase
    {
        public LoginSuccess(ContextLogin ctx) : base(ctx)
        {
        }
        public override void Newlogin(string PasswardTry)
        {
            Console.WriteLine("you are already logged in");
        }

        public override void Restart()
        {
            ctx.State = new NewLogin(ctx);
            Console.WriteLine("you are now at new login state");
        }
    }
}
