using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Entry
{
    static void Main(string[] arrgs)
    {
        AppScreen.Welcome();
        long cardNumber = Validator.Convert<long>("Your card number ");
        Console.WriteLine($"your name is {cardNumber}");

        Utility.PressEnterToContinue();
    }
}