using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX4
{
    class NewLogin : LoginBase
    {
        public NewLogin(ContextLogin ctx) : base(ctx)
        {
        }
        public override void Newlogin(string PasswardTry)
        {
            
            if (password.Equals(PasswardTry))
            {
                Console.WriteLine("you are logged in successfully");
                ctx.State = new LoginSuccess(ctx);
            }
            else
            {
                ctx.State = new LoginFailed(ctx);
                Console.WriteLine("wrong password. you can try again (2 remain)");
            }
        }

        public override void Restart()
        {
            Console.WriteLine("you are already at new login state");
        }
    }
}
