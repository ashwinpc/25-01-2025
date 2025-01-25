using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstraction.Model
{
    // Derived class basic
    public class BasicPhone : MobilePhone
    {
        public override void MakeCall(string phoneNUmber)
        {
           Console.WriteLine($" Calling {phoneNUmber} from a basic phone ");
        }
    }
}
