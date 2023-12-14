namespace DevGuru.Patterns.Facade
{
    public static class Client
    {
        public static void Operation(Facade facade)
        {
            facade.Operation();
        }
    }
}
