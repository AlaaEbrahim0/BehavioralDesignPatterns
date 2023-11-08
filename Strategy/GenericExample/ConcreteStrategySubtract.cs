namespace Strategy.GenericExample;

public class ConcreteStrategySubtract : IStrategy
{
	public int Execute(int a, int b) => a - b;
}
