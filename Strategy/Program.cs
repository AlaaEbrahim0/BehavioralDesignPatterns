using System.Collections;
using Strategy.GenericExample;

namespace Strategy;

public class Program
{
	static void Main(string[] args)
	{
		/*
		Strategy is a pattern that lets you define 
		A family of algorithms, put each of them into a separate 
		class, and make their objects interchangeable
		*/

		// Generic Example
		GenericExampleClient();

	}

	private static void GenericExampleClient()
	{
		Console.Write("Enter num1: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter num2: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("1) addition");
		Console.WriteLine("2) subtraction");
		Console.WriteLine("3) multiplication");
		Console.Write("Choose strategy: ");

		int selectedStrategy = Convert.ToInt32(Console.ReadLine());
		Context? context = null!;
		switch (selectedStrategy)
		{
			case 1:
				context = new Context(new ConcreteStrategyAdd());
				break;
			case 2:
				context = new Context(new ConcreteStrategySubtract());
				break;
			case 3:
				context = new Context(new ConcreteStrategyMultiply());
				break;
			default:
				break;
		}
		var result = context.ExecuteStrategy(num1, num2);
		Console.WriteLine($"Result: {result}");
	}

}
