using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Things;

namespace CommandPattern.Commands
{
    class GarageDoorCloseCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Close();
        }

        public void Undo()
        {
            garageDoor.Open();
        }
    }
}
