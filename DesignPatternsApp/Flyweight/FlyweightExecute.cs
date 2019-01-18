using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FlyweightExecute
    {
        public static void FlyweightCommand()
        {

            bool repeat = true;
            while (repeat)
            {
                ShapeObjectFactory sof = new ShapeObjectFactory();

                IShape shape = sof.GetShape("Rectangle");
                shape.Print();
                shape = sof.GetShape("Rectangle");
                shape.Print();
                shape = sof.GetShape("Rectangle");
                shape.Print();

                shape = sof.GetShape("Circle");
                shape.Print();
                shape = sof.GetShape("Circle");
                shape.Print();
                shape = sof.GetShape("Circle");
                shape.Print();

                int NumObjs = sof.TotalObjectsCreated;
                Console.WriteLine("\nTotal No of Objects created = {0}", NumObjs);

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