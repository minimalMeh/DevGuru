namespace DevGuru.Core.Builder
{
    public class Bakery
    {
        public void Bake(IBakingBuilder builder)
        {
            builder.SetFlour();
            builder.SetSalt();
            builder.SetWeight();
            builder.AddSupplements();
        }
    }
}
