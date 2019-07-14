using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX4
{
    public class ContextLogin
    {
        public ILoginState State { get; set; }

        public ContextLogin()
        {
        }
        public void Init(ILoginState state)
        {
            this.State = state;
        }
        public void Login(string passwordTry)
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
            State.Newlogin(passwordTry);
        }

        public void Restart()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
            State.Restart();
        }

    }
}
