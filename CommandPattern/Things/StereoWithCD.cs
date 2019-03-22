using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Things
{
    class StereoWithCD
    {
        public void On()
        {
            Console.WriteLine("StereoWithCD On");
        }

        public void Off()
        {
            Console.WriteLine("StereoWithCD Off");
        }

        public void SetCD()
        {
            Console.WriteLine("Set CD");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume: {volume}" );
        }
    }
}
