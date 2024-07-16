using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber;

            Console.WriteLine("Input the number to be reversed: ");
            myNumber = Convert.ToInt32(Console.ReadLine());

            int reversed = 0;
            int digit = 0;

            while (myNumber > 0)
            {
                digit = myNumber % 10;
                reversed = (reversed * 10) + digit;
                myNumber = myNumber /10 ;
                
            }
            Console.WriteLine(reversed);
        }

    }
}

