using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextLogin ctx = new ContextLogin();
            ctx.Init(new NewLogin(ctx));
            ctx.Login("ab");
            ctx.Login("ab");
            ctx.Login("ab");
            ctx.Login("ab");
            ctx.Restart();
            ctx.Login("ab");
            ctx.Login("BLA");
            ctx.Login("BLA");


        }
    }
}
