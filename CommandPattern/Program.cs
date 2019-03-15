using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tV = new TV();
            Pult pult = new Pult();

            pult.SetCommand(new TVOnCommand(tV));

            pult.PressButton();
            pult.PressUndo();

            Man man = new Man();
            
            pult.SetCommand(new ManCommand(man));

            pult.PressButton();
            pult.PressUndo();

            Console.ReadKey();
        }
    }
}
