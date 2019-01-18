﻿using Adapter;
using DecoratorPattern;
using FactoryMethod;
using Singleton;
using StrategyNull;
using Prototype;
using Builder;
using Bridge;
using Flyweight;
using Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;
using Facade;

namespace DesignPatternsApp
{
    public class MainMenu
    {
        public static bool userMainMenu()
        {

            Console.Title = "Design Patterns";
            Console.Clear(); //Cleans window so you can see. 
            Console.WriteLine("Here is a list of design patterns.");
            Console.WriteLine("Choose 1) Strategy/Null Object Pattern, 2)Singleton Pattern 3)Decorator Pattern " +
                "4)Factory Pattern 5) Adapter 6) Builder 7)Prototype 8)Bridge 9) Composite 10)Facade " +
                "11)Flyweight 12) Proxy"); //This is where you tell user what their options are.
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
            else if (result == "8")
            {
                BridgeExecute.BridgeCommand();
                return true;
            }
            else if (result == "9")
            {
                CompositeExecute.CompositeCommand();
                return true;
            }
            else if (result == "10")
            {
                FacadeExecute.FacadeCommand();
                return true;
            }
            else if (result == "11")
            {
                FlyweightExecute.FlyweightCommand();
                return true;
            }
            else if (result == "12")
            {
                ProxyExecute.ProxyCommand();
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
