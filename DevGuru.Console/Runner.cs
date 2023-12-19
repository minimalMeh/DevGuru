using DevGuru.Core;
using DevGuru.Patterns.AbstractFactory;
using DevGuru.Patterns.Adapter;
using DevGuru.Patterns.Bridge;
using DevGuru.Patterns.Builder;
using DevGuru.Patterns.ChainOfResponsibility;
using DevGuru.Patterns.Command;

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
                System.Console.Write("Specify pattern name: ");
                var patternName = System.Console.ReadLine()?.ToLower();

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
                    _ => null
                };

                pattern?.Run();
            }

            // Singleton 
            // https://csharpindepth.com/Articles/Singleton
            // Top-1
            //NotLazyButThreadSafeWithoutLocksSingleton singleton = NotLazyButThreadSafeWithoutLocksSingleton.Instance;
            //SimpleThreadSafeSingleton singleton2 = SimpleThreadSafeSingleton.Instance;
            //ModernLazyTypedSingleton singleton3 = ModernLazyTypedSingleton.Instance;
            //FullyLazyInstantiationSingleton singleton4 = FullyLazyInstantiationSingleton.Instance;

            // Visitor
            //var dot = new Dot(1, 10, 20);
            //var dot2 = new Dot(3, 11, 20);
            //var dot3 = new Dot(4, 12, 20);
            //var dot4 = new Dot(5, 13, 20);
            //var circle = new Circle(2, 10);

            //var exportVisitor = new XmlExportVisitor();
            //Console.WriteLine(exportVisitor.Export(dot, dot2, dot3, circle, dot4));

            // Iterator
            //var collection = new WordsCollection
            //{
            //    "First",
            //    "Second",
            //    "Third"
            //};

            //foreach(var element in collection)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.WriteLine("Reverse");

            //collection.Reverse();

            //foreach (var element in collection)
            //{
            //    Console.WriteLine(element);
            //}


            // Prototype
            //var benchmark = new Rectangle(10, 20, 200, 300);
            //Console.WriteLine(benchmark);
            //Rectangle bcopy = benchmark.Clone() as Rectangle;
            //Console.WriteLine(bcopy);
            //Console.WriteLine($"Check links\nbenchmark and copy: {benchmark == bcopy}\nbenchmark string: {benchmark.rectangleName == bcopy.rectangleName}\n{object.ReferenceEquals(benchmark.rectangleName, bcopy.rectangleName)}");


            // Decorator
            //string salary = "Name, Salary\nJohn, 1000\nLida, 2000\n";
            //DataSourceDecorator withEncryption = new EncryptionDecorator(
            //    new FileDataSource("test.txt"));

            //withEncryption.Write(salary);

            //var plainFileDataSource = new FileDataSource("test.txt");
            //Console.WriteLine("Plain file read: \n" + plainFileDataSource.Read());
            //Console.WriteLine("Decorator file read: \n" + withEncryption.Read());

            // Proxy
            //var proxy = new YouTubeCacheProxy();
            //proxy.GetPopularVideos().Values.ToList().ForEach(p => Console.WriteLine(p));
            //proxy.GetPopularVideos().Values.ToList().ForEach(p => Console.WriteLine(p));
            //proxy.GetPopularVideos().Values.ToList().ForEach(p => Console.WriteLine(p));

            //var video = proxy.GetVideo("turtle");
            //Console.WriteLine(video);

            //video = proxy.GetVideo("cat");
            //Console.WriteLine(video);

            //video = proxy.GetVideo("dog1");
            //Console.WriteLine(video);

            //video = proxy.GetVideo("dog");
            //Console.WriteLine(video);

            //video = proxy.GetVideo("turtle");
            //Console.WriteLine(video);

            //proxy.Reset();

            //video = proxy.GetVideo("dog");
            //Console.WriteLine(video);

            //video = proxy.GetVideo("turtle");
            //Console.WriteLine(video);

            // Memento + Command
            //var editor = new Editor();
            //editor.Execute(new ChangeTextCommand(editor, "Welcome!"));
            //editor.Execute(new ChangeTextCommand(editor, "Log in"));
            //editor.Execute(new MovePointerCommand(editor, 100, 100));

            //editor.History.Undo();
            //editor.History.Undo();
            //editor.History.Redo();

            //editor.Execute(new ChangeTextCommand(editor, "Try again?"));
            //editor.Execute(new MovePointerCommand(editor, 200, 250));
            //editor.History.Redo();
            //editor.History.Undo();
            //editor.History.Undo();
            //editor.History.Undo();
            //editor.History.Undo();
            //editor.History.Undo();

            //editor.History.Redo();
            //editor.Execute(new ChangeTextCommand(editor, "Dasha stop."));

            // Mediator
            //var manager = new ManagerMediator();
            //var executor = new SubordinateColleague(manager);
            //var customer = new CustomerColleague(manager);
            //manager.Customer = customer;
            //manager.Executor = executor;

            //customer.Send("I want a new release");
            //Thread.Sleep(1000);
            //executor.Send("Here is a new release");

            // Facade (фасАаад)
            //Client.Operation(new Facade(new Subsystem1(), new Subsystem2()));

            // Observer not C# sample, just observer, TODO: adequate c# event 
            //var ib = new InternetBilet();
            //var ba = new BusinessAffiche();
            //var tu = new TechnicalUniversity();
            //var rs = new RobotsSchool();

            //var eventMan = new EventManager();
            //eventMan.AttachAllEventsListener(ib);
            //eventMan.AttachBusinessListener(ba);
            //eventMan.AttachSienceListener(tu);
            //eventMan.AttachSienceListener(rs);

            //eventMan.AddBusinessEnvent(new BusinessEvent(DateTime.UtcNow, DateTime.UtcNow));
            //eventMan.AddSienceEnvent(new SienceEvent(DateTime.UtcNow, "Park Gorkogo"));
            //eventMan.AddSienceEnvent(new SienceEvent(DateTime.UtcNow, "Jellyfish museum"));

            //ib.Print();
            //ba.Print();
            //tu.Print();
            //rs.Print();

            // Compose
            //var compose = new FileSystem();
            //var root = new Folder("C:");
            //var folderA = new Folder("Alpha");
            //compose.Add(root, folderA);
            //var fileA = new File("Apartments.doc", 124);
            //compose.Add(folderA, fileA);
            //var folderB = new Folder("Beta");
            //compose.Add(root, folderB);
            //compose.Add(folderB, new File("Bye", 1064));
            //var fileB1 = new File("Bike.img", 300);
            //compose.Add(folderB, fileB1);
            //var fileR = new File("RootFile.db", 20000);
            //compose.Add(root, fileR);
            //Console.WriteLine(compose.GetSize(root));


            // Factory method
            //var dialogService = new DialogService();
            //dialogService.Initialize("windows");
            //dialogService.Render();
            //dialogService.Initialize("web");
            //dialogService.Render();

            // Abstract factory
            //GUIService.SimulateGUI("windows");
            //GUIService.SimulateGUI("goofy");
            //GUIService.SimulateGUI("mac");


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

            // FlyWeight
            //var location = new Location();

            //location.BuildHouse(0, 0, HouseLayoutType._1_201_6);
            //location.BuildHouse(0, 10, HouseLayoutType._1_201_12);
            //location.BuildHouse(0, 20, HouseLayoutType._1_201_13);
            //location.BuildHouse(0, 30, HouseLayoutType._1_201_6);
            //location.BuildHouse(0, 40, HouseLayoutType._1_207_7_Dormitory);
            //location.BuildHouse(10, 0, HouseLayoutType._1_207_7_Dormitory);
            //location.BuildHouse(20, 10, HouseLayoutType._1_207_7_Dormitory);
            //location.BuildHouse(30, 20, HouseLayoutType._1_207_7_Dormitory);
            //location.BuildHouse(40, 30, HouseLayoutType._1_201_6);

            //location.DrawHouses();
        }
    }
}
