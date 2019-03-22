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
        private List<ICommand> onCommands;
        private List<ICommand> offCommands;
        private ICommand undoCommand;

        public Pult()
        {
            this.onCommands = new List<ICommand>();
            this.offCommands = new List<ICommand>();
            this.undoCommand = new NoCommand();
        }

        public void SetCommand(ICommand onCommand, ICommand offCommand)
        {
            this.onCommands.Add(onCommand);
            this.offCommands.Add(offCommand);
        }

        public void PressOnButton(uint key)
        {
            if (this.onCommands.Count > key)
            {
                this.onCommands[(int)key].Execute();
                this.undoCommand = this.onCommands[(int)key];
            }
        }

        public void PressOffButton(uint key)
        {
            if (this.onCommands.Count > key)
            {
                this.offCommands[(int)key].Execute();
                this.undoCommand = this.offCommands[(int)key];
            }
        }

        public void PressUndo()
        {
            this.undoCommand.Undo();
        }
    }
}
