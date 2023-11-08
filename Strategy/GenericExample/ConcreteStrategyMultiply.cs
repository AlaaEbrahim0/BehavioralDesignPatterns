namespace Strategy.GenericExample;

public class ConcreteStrategyMultiply: IStrategy
{
	public int Execute(int a, int b) => a * b;
}
