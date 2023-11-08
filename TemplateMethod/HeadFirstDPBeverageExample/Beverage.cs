namespace TemplateMethod.HeadFirstDPBeverageExample;

public abstract class Beverage
{
    // Out template method
    public void GetRecipe()
    {
        boilWater();
        Brew();
        pourInCup();
        if (CustomerWantsCondiments())
            AddCondiments();
    }

    private void boilWater() => Console.WriteLine("Boiling Water ...");
    private void pourInCup() => Console.WriteLine("Pouring ...");

    protected virtual bool CustomerWantsCondiments() => true;

    protected abstract void Brew();
    protected abstract void AddCondiments();
}
