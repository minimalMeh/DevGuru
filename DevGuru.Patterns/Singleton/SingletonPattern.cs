using DevGuru.Core;

namespace DevGuru.Patterns.Singleton
{
    public class SingletonPattern : PatternBase
    {
        public override string Name => "Singleton";
        protected override string DescriptionFormatted => "\t[Ensures that a class has only one instance and provides a global point of access to that instance,]\n\t[allowing for a single, shared point of control.]\n";
        protected override string IdeaFormatted => "\t[https://csharpindepth.com/Articles/Singleton]\n";

        protected override void RunCore()
        {
            _ = NotLazyButThreadSafeWithoutLocksSingleton.Instance;
            _ = SimpleThreadSafeSingleton.Instance;
            _ = ModernLazyTypedSingleton.Instance;
            _ = FullyLazyInstantiationSingleton.Instance;
        }
    }
}
