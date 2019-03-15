using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class ManCommand : ICommand
    {
        Man man;

        public ManCommand(Man man)
        {
            this.man = man;
        }

        public void Execute()
        {
            man.Go();
        }

        public void Undo()
        {
            man.Stop();
        }
    }
}
