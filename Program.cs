// See https://aka.ms/new-console-template for more information
class ATMAPP
{
    static void Main(string[] arrgs)
    {
        AppScreen.Welcome();
        long cardNumber = Validator.Convert<long>("Your card number ");
        Console.WriteLine($"your name is {cardNumber}");

        Utility.PressEnterToContinue();
    }
}
