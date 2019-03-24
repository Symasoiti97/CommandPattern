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
            TV tv = new TV();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            StereoWithCD stereo = new StereoWithCD();

            Console.WriteLine("Pult:");

            Pult pult = new Pult();

            pult.SetCommand(0, new TVOnCommand(tv), new TVOffCommand(tv));
            pult.SetCommand(1, new LightOnCommand(light), new LightOffCommand(light));
            pult.SetCommand(2, new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));
            pult.SetCommand(3, new StereoOnWithCDCommand(stereo), new StereoOffWithCDCommand(stereo));

            pult.PressOnButton(0);
            pult.PressOnButton(1);
            pult.PressOnButton(2);
            pult.PressOnButton(3);

            pult.PressOffButton(0);
            pult.PressOffButton(1);
            pult.PressOffButton(2);
            pult.PressOffButton(3);

            pult.PressUndo();

            Console.WriteLine("\nMacroPult:");

            MacroPult macroPult = new MacroPult();

            ICommand[] onCommands = new ICommand[] {new TVOnCommand(tv),new LightOnCommand(light) };
            ICommand[] offCommands = new ICommand[] { new TVOffCommand(tv), new LightOffCommand(light) };

            MacroCommands onMacroCommands = new MacroCommands(onCommands);
            MacroCommands offMacroCommands = new MacroCommands(offCommands);

            macroPult.SetCommand(onMacroCommands, offMacroCommands);

            macroPult.PressOnButton(0);

            macroPult.PressOffButton(0);

            macroPult.PressUndo();

            Console.ReadKey();
        }
    }
}
