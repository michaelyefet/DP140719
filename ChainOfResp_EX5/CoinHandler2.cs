using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_EX5
{
    class CoinHandler2 : BillHandlerBase
    {
        public override void Handle(int amount)
        {
            if (amount == 0)
                return;

            if (amount >= 2)
            {
                Console.WriteLine($"Giving 2 x {amount / 2} bills");
            }

            if (amount % 2 > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % 2);
                }
            }
        }
    }
}
