using System;
using StrategyPattern.services;

namespace StrategyPattern
{
    public abstract class MovementStrategy : IMovementStrategy
    {
        private readonly string _template;
        private readonly IPresents _presenter;

        protected MovementStrategy(string template, IPresents presenter)
        {
            _template = template;
            _presenter = presenter;
        }

        public virtual void Move(double velocity, string direction)
        {
            var output = string.Format(_template, direction, velocity);
            _presenter.DisplayLine(output);
        }
    }
}