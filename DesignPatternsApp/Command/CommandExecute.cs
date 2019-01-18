using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CommandExecute
    {
        public static void CommandCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Enter Commands (ON/OFF) : ");
                string cmdinput = Console.ReadLine();
                string cmd = cmdinput.ToUpper();
                Light lamp = new Light();
                ICommand switchUp = new FlipUpCommand(lamp);
                ICommand switchDown = new FlipDownCommand(lamp);

                Switch s = new Switch();

                if (cmd == "ON")
                {
                    s.StoreAndExecute(switchUp);
                }
                else if (cmd == "OFF")
                {
                    s.StoreAndExecute(switchDown);
                }
                else
                {
                    Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
                }

                Console.Write("Go again? Y/N: ");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }

        }
    }
}