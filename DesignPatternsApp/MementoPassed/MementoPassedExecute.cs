using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPassed
{
    public class MementoPassedExecute
    {
        public static void MementoPassedCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                //Memento pattern aka the rollback pattern. Provides the 
                //ability to restore an object to its previous state.  
                //Implemented with two objects the originator and the caretaker. The 
                //originator is some object that has an internal state. The caretaker is going
                //to do something to the originator but wants to be able to undo the change.

                //caretaker
                IList<Memento> undos = new List<Memento>();
                Notepad notepad = new Notepad();
                Memento undo;

                //First revision
                undo = notepad.SetText("Cool!");
                undos.Add(undo);
                Console.WriteLine("Currently in the notepad: " + notepad.GetText());
                //Console.WriteLine(notepad.GetText());
                Console.WriteLine("Above line should read: Cool!");
                Console.WriteLine(" ");

                //second revision
                undo = notepad.SetText("Hello, I am mike, if you are reading this it is all good.");
                undos.Add(undo);
                Console.WriteLine("Now we put a new line in the notepad: Hello, I am mike, if you are reading this it is all good. ");
                Console.WriteLine("Currently in the notepad: " + notepad.GetText());
                //Console.WriteLine(notepad.GetText());
                Console.WriteLine("Above line should read: Hello, I am mike, if you are reading this it is all good.");
                Console.WriteLine(" ");

                Console.WriteLine("Issue the undo command.");
                notepad.UnDo(undos[1]);
                Console.WriteLine(" ");

                Console.WriteLine("Currently in the notepad (after undo): " + notepad.GetText());
                Console.WriteLine("Above line should read: Cool!");
                //Console.WriteLine(notepad.GetText());
                //Console.WriteLine("Cool!");
                Console.WriteLine(" ");
                Console.WriteLine("Issue the undo command again. (Should be blank!)");
                notepad.UnDo(undos[0]);
                Console.WriteLine("Currently in the notepad (after undo): " + notepad.GetText());
                Console.WriteLine("Above line should read: blank!");
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
