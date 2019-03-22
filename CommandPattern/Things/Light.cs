using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Things
{
    class Light
    {
        public void On()
        {
            Console.WriteLine("On light");
        }

        public void Off()
        {
            Console.WriteLine("Off light");
        }
    }
}
