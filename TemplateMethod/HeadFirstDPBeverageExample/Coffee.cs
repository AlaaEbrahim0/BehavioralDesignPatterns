namespace TemplateMethod.HeadFirstDPBeverageExample;

public class Coffee : Beverage
{
    protected override void AddCondiments()
    {
        Console.WriteLine("\nAdding Milk And Sugar");
    }

    protected override void Brew()
    {
        Console.WriteLine("Brewing Coffee ...");
    }

    private ConsoleKey getUserInput()
    {
        var input = Console.ReadKey();
        return input.Key;
    }

    protected override bool CustomerWantsCondiments()
    {
        Console.Write("Would you like milk and sugar with your coffee(y / n): ");
        var input = getUserInput();
        if (input == ConsoleKey.Y)
            return true;
        else
            return false;
    }

}
