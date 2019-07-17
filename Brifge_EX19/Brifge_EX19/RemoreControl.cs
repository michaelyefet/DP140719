using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brifge_EX19
{
    class RemoreControl
    {
        protected EntertainmentDevice Device;

        public RemoreControl(EntertainmentDevice Device)
        {
            this.Device = Device;
        }
        public EntertainmentDevice GetDevice()
        {
            return this.Device;
        }

        public void SetDevice(EntertainmentDevice Device)
        {
            this.Device = Device;
        }

        public void On()
        {
            Device.TurnOn();
        }

        public void Off()
        {
            Device.TurnOff();
        }

        public void Next()
        {
            Device.PressNext();
        }

        public void Prev()
        {
            Device.PressPrev();
        }

        public void PrintState()
        {
            Device.PrintState();
        }
    }
}
