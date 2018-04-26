using DecoratorPattern;
using FactoryMethod;
using Singleton;
using StrategyNull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp
{
    public class MainMenu
    {
        public static bool userMainMenu()
        {
            Console.Clear(); //Cleans window so you can see.
            Console.WriteLine("Here is a list of design patterns.");
            Console.WriteLine("Chose 1) Strategy/Null Object Pattern, 2)Singleton Pattern 3)Decorator Pattern 4)Factory Pattern"); //This is where you tell user what their options are.
            string result = Console.ReadLine();
            if (result == "1")
            {
                StrategyExecute.StrategyCommand();
                return true;
            }
            else if (result == "2")
            {
                SingletonExecute.SingletonCommand();
                return true;
            }
            else if (result == "3")
            {
                DecoratorExecute.DecoratorCommand();
                return true;
            }
            else if (result == "4")
            {
                FactoryExecute.FactoryCommand();
                return true;
            }

            else
            {
                Null.Object();//Dont have to have null(else catches all) but it looks nice.
                return false;
            }
        }
    }
}
