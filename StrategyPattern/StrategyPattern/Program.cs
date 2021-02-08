using System;
using System.IO;
using System.Linq;
using Autofac;
using StrategyPattern.services;

namespace StrategyPattern
{
    internal static class Program
    {

        private const string Path = "/home/hackerbuddy/repos/strategy-pattern-stuff/StrategyPattern/StrategyPattern/menu.ui";
        
        private static void Main(string[] args)
        {
            var container = BuildDependencyContainer();
            var app = container.Resolve<Application>();
            app.Run();
        }

        private static IContainer BuildDependencyContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Presenter>().As<IPresents>().InstancePerLifetimeScope();
            builder.RegisterType<MovementStrategyFactory>().As<IMovementStrategyFactory>().InstancePerLifetimeScope();
            builder.RegisterType<UiService>().As<IUiService>().InstancePerLifetimeScope();

            builder.RegisterType<Application>().AsSelf().InstancePerLifetimeScope();
            
            return builder.Build();
        }




    }
}
