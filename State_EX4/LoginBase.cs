using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX4
{
    public abstract class LoginBase : ILoginState
    {
        protected const string password = "BLA";
        protected ContextLogin ctx;

        public LoginBase(ContextLogin ctx)
        {
            this.ctx = ctx;
        }
        public abstract void Newlogin(string PasswardTr);

        public abstract void Restart();
    }
}
