using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;

namespace CommandPattern
{
    class Pult
    {
        private ICommand undoCommand;
        Dictionary<int, Command> commands;

        public Pult()
        {
            commands = new Dictionary<int, Command>();
            this.undoCommand = new NoCommand();
        }

        public void SetCommand(int key, ICommand onCommand, ICommand offCommand)
        {
            Command command = new Command(onCommand, offCommand);
            commands.Add(key, command);
        }

        public void PressOnButton(int key)
        {
            if (this.commands[key] != null)
            {
                this.commands[key].onCommand.Execute();
                this.undoCommand = this.commands[key].onCommand;
            }
        }

        public void PressOffButton(int key)
        {
            if (this.commands[key] != null)
            {
                this.commands[key].offCommand.Execute();
                this.undoCommand = this.commands[key].offCommand;
            }
        }

        public void PressUndo()
        {
            this.undoCommand.Undo();
        }
    }
}
