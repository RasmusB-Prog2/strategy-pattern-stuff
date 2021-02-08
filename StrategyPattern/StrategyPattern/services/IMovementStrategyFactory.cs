namespace StrategyPattern.services
{
    public interface IMovementStrategyFactory
    {
        IMovementStrategy CreateStrategy<T>();
    }
}