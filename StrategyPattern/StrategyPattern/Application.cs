using System;
using System.IO;
using Autofac;
using StrategyPattern.services;

namespace StrategyPattern
{
    public class Application
    {
        private readonly IMovementStrategyFactory _factory;
        private readonly IUiService _uiService;
        private readonly IPresents _presenter;

        public Application(IMovementStrategyFactory factory, IUiService uiService, IPresents presenter)
        {
            _factory = factory;
            _uiService = uiService;
            _presenter = presenter;
        }

        public void Run()
        {
            PrintMenu();
            var movementStrategy = GetStrategyByInput();
            movementStrategy.Move(118, "West");
        }
        
        private IMovementStrategy GetStrategyByInput() =>
            Console.ReadLine() switch
            {
                "1" => _factory.CreateStrategy<WalkStrategy>(),
                "2" => _factory.CreateStrategy<RunStrategy>(),
                "3" => _factory.CreateStrategy<FlyStrategy>(),
                _ => null
            };
            
            
        
        
        private void PrintMenu()
        {
            _presenter.DisplayLine(_uiService.GetUi());
        }
    }
}