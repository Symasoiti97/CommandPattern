using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Things;
using CommandPattern.Commands;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();

            TV tv = new TV();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            StereoWithCD stereo = new StereoWithCD();

            pult.SetCommand(new TVOnCommand(tv), new TVOffCommand(tv));
            pult.SetCommand(new LightOnCommand(light), new LightOffCommand(light));
            pult.SetCommand(new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));
            pult.SetCommand(new StereoOnWithCDCommand(stereo), new StereoOffWithCDCommand(stereo));

            pult.PressOnButton(0);
            pult.PressOnButton(1);
            pult.PressOnButton(2);
            pult.PressOnButton(3);

            pult.PressOffButton(0);
            pult.PressOffButton(1);
            pult.PressOffButton(2);
            pult.PressOffButton(3);

            pult.PressUndo();

            Console.ReadKey();
        }
    }
}
