// See https://aka.ms/new-console-template for more information
class ATMAPP
{
    static void Main(string[] arrgs)
    {
        AppScreen.Welcome();
        string name = Utility.GetUserInput("your name");
        Console.WriteLine($"your name is {name}");

        Utility.PressEnterToContinue();
    }
}
