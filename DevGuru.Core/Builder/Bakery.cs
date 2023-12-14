namespace DevGuru.Core.Builder
{
    public class Bakery
    {
        public static void Bake(IBakingBuilder builder)
        {
            builder.SetFlour();
            builder.SetSalt();
            builder.SetWeight();
            builder.AddSupplements();
        }
    }
}
