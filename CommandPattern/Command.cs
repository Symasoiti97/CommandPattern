using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;

namespace CommandPattern
{
    class Command
    {
        public ICommand onCommand { get; private set; }
        public ICommand offCommand { get; private set; }

        public Command(ICommand onCommand, ICommand offCommand)
        {
            this.onCommand = onCommand;
            this.offCommand = offCommand;
        }
    }
}
