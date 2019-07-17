using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brifge_EX19
{
    class TV : EntertainmentDevice
    {
        public TV(int state, int max, bool IsOn) : base(state, max, IsOn)
        {
        }

        public override void PressNext()
        {
            Console.WriteLine("Moving to the next channel....");
            this.state = (this.state + 1 + this.max) % this.max ;
        }

        public override void PressPrev()
        {
            Console.WriteLine("Moving to the previous channel....");
            this.state = (this.state - 1 + this.max) % this.max;
        }

        public override void PrintState()
        {
            Console.WriteLine($"this current channel state is {this.state}");
        }
    }
}
