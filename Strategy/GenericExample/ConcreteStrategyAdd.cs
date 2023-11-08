namespace Strategy.GenericExample;

public class ConcreteStrategyAdd : IStrategy
{
	public int Execute(int a, int b) => a + b;
}
