using DevGuru.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Core
{
    [Flags]
    public enum Pattern
    {
        None = 0,
        AbstractFactory,
        Adapter,
        Bridge,
        Builder,
        ChainOfResponsibility,
        Command,
        Composite,
        Decorator,
        Facade,
        FactoryMethod,
        Flyweight,
        Iterator,
        Mediator,
        Memento,
        Observer,
        Prototype,
        Proxy,
        Singleton,
        State,
        Strategy,
        TemplateMethod,
        Visitor
    }

    public static class PatternsCollection
    {
        private static readonly Dictionary<Pattern, IPattern> patterns = new();

        private static readonly Dictionary<Pattern, string[]> patternAliases = new()
        {
            { Pattern.AbstractFactory, new [] { "abstract factory", "af" } },
            { Pattern.Adapter, new [] { "adapter", "ad" } },
            { Pattern.Bridge, new [] { "bridge", "bdg" } },
            { Pattern.Builder, new [] { "builder", "bldr" } },
            { Pattern.ChainOfResponsibility, new [] { "chain of responsibility", "chain", "cor" } },
            { Pattern.Command, new [] { "command", "cmd" } },
            { Pattern.Composite, new [] { "compose", "cmps", "compositor" } },
            { Pattern.Decorator, new [] { "decorator", "dcr", "decor" } },
            { Pattern.Facade, new [] { "facade", "fcd" } },
            { Pattern.FactoryMethod, new [] { "factory method", "fm", "fmethod" } },
            { Pattern.Flyweight, new [] { "flyweight", "fw", "fly" } },
            { Pattern.Iterator, new [] { "iterator", "it", "iterate", "list" } },
            { Pattern.Mediator, new [] { "mediator", "mdtr" } },
            { Pattern.Memento, new [] { "memento", "mmnt", "moment" } },
            { Pattern.Observer, new [] { "observer", "obs", "pubsub" } },
            { Pattern.Prototype, new [] { "prototype", "prt", "proto" } },
            { Pattern.Proxy, new [] { "proxy", "prx"} },
            { Pattern.Singleton,  new [] { "singleton", "sngl", "single" } },
            { Pattern.State, new [] { "state", "st"} },
            { Pattern.Strategy, new [] { "strategy", "strtg"} },
            { Pattern.TemplateMethod, new [] { "template method", "tm", "tmethod"} },
            { Pattern.Visitor, new [] { "visitor", "vstr", "visit"} }
        };

        public static Dictionary<Pattern, string[]> PatternAliases => patternAliases;

        public static IPattern GetPatternByAlias(string patternAlias)
        {
            Pattern pattern = patternAliases.Where(a => a.Value.Contains(patternAlias)).FirstOrDefault().Key;
            return GetOrCreate(pattern);
        }

        private static IPattern GetOrCreate(Pattern pattern)
        {
            bool patternExist = patterns.TryGetValue(pattern, out IPattern foundPattern);

            if (patternExist)
            {
                return foundPattern;
            }

            var createdPattern = CreatePattern(pattern);
            patterns[pattern] = createdPattern;
            return createdPattern;
        }

        private static IPattern CreatePattern(Pattern pattern) => pattern switch
        {
            Pattern.AbstractFactory => new AbstractFactoryPattern(),
            Pattern.Adapter => new AdapterPattern(),
            Pattern.Bridge => new BridgePattern(),
            Pattern.Builder => new BuilderPattern(),
            Pattern.ChainOfResponsibility => new ChainOfResponsibilityPattern(),
            Pattern.Command => new CommandPattern(),
            Pattern.Composite => new CompositePattern(),
            Pattern.Decorator => new DecoratorPattern(),
            Pattern.Facade => new FacadePattern(),
            Pattern.FactoryMethod => new FactoryMethodPattern(),
            Pattern.Flyweight => new FlyweightPattern(),
            Pattern.Iterator => new IteratorPattern(),
            Pattern.Mediator => new MediatorPattern(),
            Pattern.Memento => new MementoPattern(),
            Pattern.Observer => new ObserverPattern(),
            Pattern.Prototype => new PrototypePattern(),
            Pattern.Proxy => new ProxyPattern(),
            Pattern.Singleton => new SingletonPattern(),
            Pattern.State => new StatePattern(),
            Pattern.Strategy => new StrategyPattern(),
            Pattern.TemplateMethod => new TemplateMethodPattern(),
            Pattern.Visitor => new VisitorPattern(),
            Pattern.None or _ => throw new ArgumentException($"Invalid {nameof(Pattern)}.")
        };
    }
}
