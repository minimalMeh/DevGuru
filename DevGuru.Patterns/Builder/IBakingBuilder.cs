namespace DevGuru.Patterns.Builder
{
    public interface IBakingBuilder
    {
        public void SetFlour();
        public void SetSalt();
        public void SetWeight();
        public void AddSupplements();
    }
}
