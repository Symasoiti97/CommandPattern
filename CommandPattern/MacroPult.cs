using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;

namespace CommandPattern
{
    class MacroPult
    {
        private List<MacroCommands> onMacroCommands;
        private List<MacroCommands> offMacroCommands;
        private MacroCommands undoMacroCommand;

        public MacroPult()
        {
            this.onMacroCommands = new List<MacroCommands>();
            this.offMacroCommands = new List<MacroCommands>();
            this.undoMacroCommand = new MacroCommands();
        }

        public void SetCommand(MacroCommands onMacroCommands, MacroCommands offMacroCommands)
        {
            this.onMacroCommands.Add(onMacroCommands);
            this.offMacroCommands.Add(offMacroCommands);
        }

        public void PressOnButton(uint key)
        {
            if (this.onMacroCommands.Count > key)
            {
                this.onMacroCommands[(int)key].Execute();
                this.undoMacroCommand = this.onMacroCommands[(int)key];
            }
        }

        public void PressOffButton(uint key)
        {
            if (this.onMacroCommands.Count > key)
            {
                this.offMacroCommands[(int)key].Execute();
                this.undoMacroCommand = this.offMacroCommands[(int)key]; 
            }
        }

        public void PressUndo()
        {
            this.undoMacroCommand.Undo();
        }
    }
}