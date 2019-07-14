using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX4
{
    class LoginFailed : LoginBase
    {
        private int counter = 2;

        public LoginFailed(ContextLogin ctx) : base(ctx)
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
                this.counter--;
                if (this.counter == 0 )
                {
                    ctx.State = new Locked(ctx);
                    Console.WriteLine("you got your password wrong too for the third time. tou are now locked :(");
                }
                else
                {
                    Console.WriteLine("wrong password. you can try again (" + this.counter + " remain)");
                }
                
            }
        }

        public override void Restart()
        {
            ctx.State = new NewLogin(ctx);
            Console.WriteLine("you are now at new login state");
        }
    }
}
