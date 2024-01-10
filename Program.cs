using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John"; 
            int age  = 10;
            bool isTall = false;
            double weight = 25.6; 

            Console.WriteLine("Hi "+name+", you are "+age+" your weight is "+ weight);
            Console.WriteLine("True or false, are you tall: "+ isTall);

            Console.ReadLine();
        }
    }
}
