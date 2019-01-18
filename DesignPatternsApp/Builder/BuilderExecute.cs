using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuilderExecute
    {
        public static void BuilderCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                var vehicleCreator = new VehicleCreator(new HeroBuilder());
                vehicleCreator.CreateVehicle();
                var vehicle = vehicleCreator.GetVehicle();
                vehicle.ShowInfo();
                Console.WriteLine("---------------------------------------------");
                vehicleCreator = new VehicleCreator(new HondaBuilder());
                vehicleCreator.CreateVehicle();
                vehicle = vehicleCreator.GetVehicle();
                vehicle.ShowInfo();
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
