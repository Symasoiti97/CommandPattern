using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Things;

namespace CommandPattern.Commands
{
    class TVOffCommand : ICommand
    {
        TV tV;
        
        public TVOffCommand(TV tV)
        {
            this.tV = tV;
        }

        public void Execute()
        {
            tV.Off();
        }

        public void Undo()
        {
            tV.On();
        }
    }
}
