namespace TemplateMethod.HeadFirstDPBeverageExample;

public class Tea : Beverage
{
    protected override void AddCondiments()
    {
        Console.WriteLine("\nAdding Lemon");
    }

    protected override void Brew()
    {
        Console.WriteLine("Brewing tea ...");
    }

    private ConsoleKey getUserInput()
    {
        var input = Console.ReadKey();
        return input.Key;
    }

    protected override bool CustomerWantsCondiments()
    {
        Console.Write("Would you like lemmon with your tea(y / n): ");
        var input = getUserInput();
        if (input == ConsoleKey.Y)
            return true;
        else
            return false;
    }


}
