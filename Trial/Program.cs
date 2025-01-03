using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number, result;
            Console.WriteLine("Please Enter The Number: ");
            number = double.Parse(Console.ReadLine());
            result = number * 18 / 100;
            Console.WriteLine("18 Percent of The Entered Number :{0}",result);
            Console.ReadKey();
        }
    }
}
