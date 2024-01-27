using DevGuru.Core;
using DevGuru.Patterns.AbstractFactory;
using DevGuru.Patterns.Adapter;
using DevGuru.Patterns.Bridge;
using DevGuru.Patterns.Builder;
using DevGuru.Patterns.ChainOfResponsibility;
using DevGuru.Patterns.Command;
using DevGuru.Patterns.Compose;
using DevGuru.Patterns.Decorator;
using DevGuru.Patterns.Facade;
using DevGuru.Patterns.FactoryMethod;
using DevGuru.Patterns.Flyweight;
using DevGuru.Patterns.Iterator;
using DevGuru.Patterns.Mediator;
using DevGuru.Patterns.Memento;
using DevGuru.Patterns.Observer;
using DevGuru.Patterns.Prototype;
using DevGuru.Patterns.Proxy;
using DevGuru.Patterns.Singleton;
using DevGuru.Patterns.State;
using DevGuru.Patterns.Strategy;
using DevGuru.Patterns.TemplateMethod;
using DevGuru.Patterns.Visitor;

namespace DevGuru.Console
{
    public static class Runner
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("GOF PATTERNS CONSOLE APP");
            System.Console.WriteLine("Q: exit\nC: clean\n");

            while (true)
            {
                System.Console.Write("Specify the pattern's name: ");
                var patternName = System.Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(patternName))
                    continue;

                if (patternName == "q" || patternName == "quit")
                    break;

                if (patternName == "c")
                {
                    System.Console.Clear();
                    continue;
                }

                IPattern pattern = patternName.ToLower() switch
                {
                    "abstract" or "abstract factory" => new AbstractFactoryPattern(),
                    "adapter" or "adapt" => new AdapterPattern(),
                    "bridge" => new BridgePattern(),
                    "builder" or "bldr" => new BuilderPattern(),
                    "cor" or "chain of responsibility" or "chain" or "responsibility" or "chainofresponsibility" => new ChainOfResponsibilityPattern(),
                    "command" or "cmd" => new CommandPattern(),
                    "composite" or "compose" or "compositor" => new CompositePattern(),
                    "decorator" or "decor" => new DecoratorPattern(),
                    "facade" => new FacadePattern(),
                    "factory method" => new FactoryMethodPattern(),
                    "fly" or "flyweight" => new FlyweightPattern(),
                    "iterator" => new IteratorPattern(),
                    "mediator" => new MediatorPattern(),
                    "memento" => new MementoPattern(),
                    "observer" => new ObserverPattern(),
                    "prototype" or "proto" => new PrototypePattern(),
                    "proxy" => new ProxyPattern(),
                    "singleton" or "single" => new SingletonPattern(),
                    "state" => new StatePattern(),
                    "strategy" => new StrategyPattern(),
                    "template method" or "template" => new TemplateMethodPattern(),
                    "visitor" => new VisitorPattern(),
                    _ => null
                };

                if (pattern == null)
                {
                    System.Console.WriteLine("No such pattern found.");
                }
                else
                {
                    pattern?.Run();
                }
            }
        }
    }
}
