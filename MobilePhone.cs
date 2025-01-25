using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstraction.Model
{
    public abstract class MobilePhone
    {
        // Common properties for all mobile phones
        public String Brand { get; set; }
        public String Model { get; set; }
        public double Price { get; set; }
        // Abstract method that must be implemented by derived classes

        public abstract void MakeCall(string phoneNUmber);
        // virtual method with a default implementation  - concerte
        public virtual void SendMessage(string phoneNUmber,string message)
        {
            Console.WriteLine($"Sending message to {phoneNUmber}:{message}");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Brand : {Brand}, Model : {Model}, Price ${Price:F2}");
        }
    }
}
