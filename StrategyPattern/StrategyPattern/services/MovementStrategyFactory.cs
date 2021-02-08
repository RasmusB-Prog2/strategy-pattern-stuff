using System;

namespace StrategyPattern.services
{
    public class MovementStrategyFactory : IMovementStrategyFactory
    {
        private readonly IPresents _presenter;

        public MovementStrategyFactory(IPresents presenter)
        {
            _presenter = presenter;
        }

        public IMovementStrategy CreateStrategy<T>() =>
            (IMovementStrategy) Activator.CreateInstance(typeof(T), new object[] { _presenter });
    }
}