using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Utility
{
    public static string GetUserInput(string Prompt)
    {
        Console.WriteLine($"Enter {Prompt}");
        return Console.ReadLine();
    }
    public static void PressEnterToContinue()
    {
        Console.WriteLine("\n\n Press Enter TO continue");
        Console.ReadLine();
    }
}