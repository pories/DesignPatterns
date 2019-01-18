﻿using Adapter;
using DecoratorPattern;
using FactoryMethod;
using Singleton;
using StrategyNull;
using Prototype;
using Builder;
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

            Console.Title = "Design Patterns";
            Console.Clear(); //Cleans window so you can see. 
            Console.WriteLine("Here is a list of design patterns.");
            Console.WriteLine("Choose 1) Strategy/Null Object Pattern, 2)Singleton Pattern 3)Decorator Pattern 4)Factory Pattern 5) Adapter 6) Builder 7)Prototype"); //This is where you tell user what their options are.
            Console.WriteLine("Or hit any other key to exit.");
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
                FactoryExecute.Execute();
                return true;
            }
            else if (result == "5")
            {
                AdapterExe.Execute();
                return true;
            }
            else if (result == "6")
            {
                BuilderExecute.BuilderCommand();
                return true;
            }
            else if (result == "7")
            {
                PrototypeExecute.PrototypeCommand();
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
