﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TVOnCommand : ICommand
    {
        TV tV;
        
        public TVOnCommand(TV tV)
        {
            this.tV = tV;
        }

        public void Execute()
        {
            tV.On();
        }

        public void Undo()
        {
            tV.Off();
        }
    }
}
