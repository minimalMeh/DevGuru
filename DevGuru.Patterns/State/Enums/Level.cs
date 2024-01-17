namespace DevGuru.Patterns.State.Enums
{
    public enum Level
    {
        Begginer,
        Intermediate,
        Advanced
    }

    public static class LevelExtensions
    {
        public static string GetName(this Level level) =>
            level switch
            {
                Level.Begginer => "Begginer",
                Level.Intermediate => "Intermediate",
                Level.Advanced => "Advanced",
                _ => "Invalid",
            };
    }
}
