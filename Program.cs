using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_asp_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter random value \n");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"type : {y.GetType()}");
        }
    }
}
