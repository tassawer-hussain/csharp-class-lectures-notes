using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec8Events
{
    // declare delegate
    delegate void MyEventHandler();

    // Publisher Class
    class Button
    {
        // An event always belongs to some class
        public event MyEventHandler click;

        public void OnClick()
        {
            if (click != null)
            {
                click();
            }
        }
    }

    class HandlerClass
    {
        public void EventHandlerFunction()
        {
            Console.WriteLine("Event Handler get called. Function 'EventHandlerFunction' inside Class 'HandlerClass'");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Button btn = new Button();

            // registering the event handler
            btn.click += delegate {
                Console.WriteLine("Event Occured");
            };

            // registering the event handler
            btn.click += () => Console.WriteLine("Event occured and we are in Lambda Expression");

            // Create instance of HandlerClass
            HandlerClass handler = new HandlerClass();
            
            // registering the event handler
            btn.click += handler.EventHandlerFunction;

            // firing the event
            btn.OnClick();

            Console.ReadKey();

        }
    }
}
