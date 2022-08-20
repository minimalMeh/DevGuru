namespace DevGuru.Core.State.Enums
{
    public enum Level
    {
        Begginer,
        Intermediate,
        Advanced
    }

    public static class LevelExtensions
    {
        public static string GetString(this Level lvl)
        {
            return lvl switch
            {
                Level.Begginer => "Begginer",
                Level.Intermediate => "Intermediate",
                Level.Advanced => "Advanced",
                _ => "NO VALUE GIVEN",
            };
        }
    }
}
