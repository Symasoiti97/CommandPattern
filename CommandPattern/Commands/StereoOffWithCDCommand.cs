using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Things;

namespace CommandPattern.Commands
{
    class StereoOffWithCDCommand : ICommand
    {
        StereoWithCD stereo;

        public StereoOffWithCDCommand(StereoWithCD stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }
    }
}
