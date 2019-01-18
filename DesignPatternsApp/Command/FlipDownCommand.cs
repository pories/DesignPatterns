using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // The Command for turning off the light - ConcreteCommand #2 
    public class FlipDownCommand : ICommand
    {
        private Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
