using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class AppScreen
{
    internal static void Welcome()
    {
        // clear terminal
        Console.Clear();
        Console.Title = "MY ATM App";
        // set Terminal Color
        Console.ForegroundColor = ConsoleColor.White;

        //set welcome message 
        Console.WriteLine("\n\n.......... Welcome To My ATM ........\n\n");
        // Prompt
        Console.WriteLine("Please insert your Atm Card");
        Console.WriteLine("Note: Actual Machine will validate a Physical ATM card");
        Utility.PressEnterToContinue();
    }

    internal static UserAccount UserLoginForm()
    {
        UserAccount tempUserAccount = new UserAccount();

        tempUserAccount.CardNumber = Validator.Convert<long>("Your Card number");
        tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter Your Card Pin"));
        return tempUserAccount;
    }
    internal static void LoginProcess()
    {
        Console.WriteLine("\nChecking Card number and PIN ...");
        Utility.PrintDotAnimation();

    }
    internal static void PrintLockedScreen()
    {
        Console.Clear();
        Utility.PrintError(" Your account is Loacked Please visit Branch ti unlock", true);

        Utility.PressEnterToContinue();
        Environment.Exit(1);
    }

}
