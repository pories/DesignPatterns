using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // The Command for turning on the light - ConcreteCommand #1 
    public class FlipUpCommand : ICommand
    {
        private Light _light;

        public FlipUpCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
