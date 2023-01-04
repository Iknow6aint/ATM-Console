// See https://aka.ms/new-console-template for more information
class ATMAPP
{
    static void Main(string[] arrgs)
    {
        AppScreen.Welcome();
        string cardNumber = Utility.GetUserInput("your Card number");
        Console.WriteLine($"your name is {cardNumber}");

        Utility.PressEnterToContinue();
    }
}
