using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decalre variables
            string name = "Mabu";
            int age;

            //initiation 
            name = "Mabu";
            age = 18;
            
            //what will b seen on the console
            Console.WriteLine("There was once a girl called " + name);
            Console.WriteLine(name + " was " + age +   "of age");
            Console.WriteLine(name + "really never liked her name.");

            //change variable values
            age = 25;
            name = "Nelca";

            Console.WriteLine("At age" + age +   " she changed her name to"  + name);

            //to freeze the console
            Console.ReadLine();

          
        }
    }
}
