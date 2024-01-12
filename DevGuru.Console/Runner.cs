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

                if (patternName == "q")
                    break;

                if (patternName == "c")
                    System.Console.Clear();

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

            // Visitor
            //var dot = new Dot(1, 10, 20);
            //var dot2 = new Dot(3, 11, 20);
            //var dot3 = new Dot(4, 12, 20);
            //var dot4 = new Dot(5, 13, 20);
            //var circle = new Circle(2, 10);

            //var exportVisitor = new XmlExportVisitor();
            //Console.WriteLine(exportVisitor.Export(dot, dot2, dot3, circle, dot4));


            // State
            //var context = new Curriculum(new BegginerLevel(), "Math");
            //context.ShowPreparationInstruction();
            //context.ShowRequiredExams();
            //if (context.Exam())
            //{
            //    context.TransitionTo(new IntermediateLevel());
            //    context.ShowPreparationInstruction();
            //    context.ShowRequiredExams();
            //    if (context.Exam())
            //    {
            //        context.TransitionTo(new AdvancedLevel());
            //        context.ShowPreparationInstruction();
            //        context.ShowRequiredExams();
            //    }
            //}

            //context = new Curriculum(new IntermediateLevel(), "Chemistry");
            //context.ShowRequiredExams();
            //if (context.Exam())
            //{
            //    context.TransitionTo(new AdvancedLevel());
            //}

            // TemplateMethod
            //var passport = new FileInfo("diya\\passport.txt");
            //var inn = new FileInfo("inn.txt");
            //var eSign = new FileInfo("diya\\key.dat");
            //EntrepreneurClient.SendRequestToBeEntrepreneur(new DiyaEntrepreneurService(), passport, inn, eSign);
            //EntrepreneurClient.SendRequestToBeEntrepreneur(new NotaryEnrepreneurService(), passport, inn);

            // Strategy
            //int [] array = { 1, 2, 3, 12, 312, 312, 12, 2, 3, 34, 5, 35, 2, 3, 24, 23, 31, 24, 235, 346, 4, 2, 3, 4 };
            //string [] array2 = { "lox", "LAH", "HAHAHAH", "SASAT" , "d", "manchester", "no", "yes" , "dasha" };
            //char [] array3 = { 'd', 'a', '2' , 'l', 'G', 'A', 'U', 'u' };

            //var intSortMachine = new SortMachine<int>();
            //var stringSortMachine = new SortMachine<string>();
            //var charSortMachine = new SortMachine<char>();

            //intSortMachine.SetStrategy(new BubbleSort<int>());
            //stringSortMachine.SetStrategy(new SelectionSort<string>());

            //intSortMachine.Sort(array);
            //stringSortMachine.Sort(array2);

            //intSortMachine.SetStrategy(new SelectionSort<int>());
            //stringSortMachine.SetStrategy(new BubbleSort<string>());

            //intSortMachine.Sort(array);
            //stringSortMachine.Sort(array2);

            //charSortMachine.SetStrategy(new BubbleSort<char>());
            //charSortMachine.Sort(array3);
        }
    }
}
