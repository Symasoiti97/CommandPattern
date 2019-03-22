using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class MacroCommands : ICommand
    {
        ICommand[] commands;

        public MacroCommands(params ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                this.commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                this.commands[i].Undo();
            }
        }
    }
}
