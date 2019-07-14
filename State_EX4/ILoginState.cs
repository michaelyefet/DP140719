using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX4
{
    public interface ILoginState
    {
        void Newlogin(string PasswardTry);

        void Restart();
    }
}
