using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1IndexerDemo.Model
{
     // step 1
    public class Employee
    {
        // data members
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
           this.Id = id;
            this.Name = name;
        }
        // step 2  : Creater Indexer
        // modifier returnType this [int/string]
        public object this[int index]
        {
            // get Accessor
            get 
            {
                if (index == 0)

                    return Id;

                else if (index == 1)
                    return Name;

                else return null;
            }
            // set Accessor
            set
            {

                if (index == 0)

                    Id=Convert.ToInt32(value);

                else if (index == 1)
                     Name=value.ToString();

               

            }
        }
    }
}
