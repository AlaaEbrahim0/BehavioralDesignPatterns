namespace Strategy.GenericExample;

public class Context
{
	public IStrategy? strategy;

	public Context(IStrategy? strategy)
	{
		this.strategy = strategy;
	}

	public void SetStrategy(IStrategy strategy) => this.strategy = strategy;

	public int ExecuteStrategy(int a, int b)
		=> strategy.Execute(a, b);

}