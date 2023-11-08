using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using TemplateMethod.HeadFirstDPBeverageExample;

namespace TemplateMethod;

internal class Program
{
	static void Main(string[] args)
	{
		Beverage? beverage = null!;

        Console.WriteLine("1) Tea");
        Console.WriteLine("2) Coffee");

		var choice = Convert.ToInt32(Console.ReadLine());
		if (choice == 1)
			beverage = new Tea();
		else if (choice == 2)
			beverage = new Coffee();
		else
			Console.WriteLine("Invalid choice");

		beverage.GetRecipe();

    }
}
