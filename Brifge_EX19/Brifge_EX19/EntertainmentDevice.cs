using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brifge_EX19
{
    abstract class EntertainmentDevice
    {
        protected int state;
        protected int max;
        protected bool IsOn;

        public EntertainmentDevice(int state, int max, bool IsOn)
        {
            this.state = state;
            this.max = max;
            this.IsOn = IsOn;
        }

        abstract public void PrintState();

        abstract public void PressNext();

        abstract public void PressPrev();

        public void TurnOn ()
        {
            this.IsOn = true;
        }

        public void TurnOff()
        {
            this.IsOn = false;
        }

    }
}
