using ConsoleApp1IndexerDemo.Model;

namespace ConsoleApp1IndexerDemo
{
    internal class Program
    {
        // indexer in C # provide a convinent way to access element of a collection or class instance in a similar
        //manner to arrays here are some adavanages of using indexers:
        //Simplified Syntax:Indexers allow you to acess elements of a collection or classusig array-like syntax([]).
        // with indexers:Directly access elements using array like syntax
        //without indesxer:requires explicit method or properties calls to acces elements,indexers offer a more concise readable,and encapusalte
        //way to access elements within a class
        static void Main(string[] args)
        {
            // Step 3 --- GetInput from the user
            Console.Write("ENTER id :");
            int empId=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ener NAme");
            string empName=Console.ReadLine();
            // create an instance
            Employee  emp= new Employee(empId,empName);
            // output resut
            Console.WriteLine("Emp id : " + emp[0]);
            Console.WriteLine("Emp NAme: "+ emp[1]);
            Console.WriteLine("press any key to continue ........");
            Console.ReadKey();
        }
    }
}
