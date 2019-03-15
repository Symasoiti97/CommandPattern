using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Man
    {
        public void Go()
        {
            Console.WriteLine("Идти!");
        }

        public void Stop()
        {
            Console.WriteLine("Остановиться!");
        }
    }
}
