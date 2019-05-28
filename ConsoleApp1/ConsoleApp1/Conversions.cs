using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 203981;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;


            double myDouble = 13.37;
            int myInt;

            //explicit conversion
            //cast double to int
            myInt = (int)myDouble;

            //typeConversion
            string myString = myDouble.ToString();
            num.ToString();
            myFloat.ToString();
            bool sunIsShining = true;

            string myBoolString = sunIsShining.ToString();


            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
