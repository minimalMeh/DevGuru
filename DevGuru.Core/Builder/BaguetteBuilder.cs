using System;

namespace DevGuru.Core.Builder
{
    public class BaguetteBuilder : IBakingBuilder
    {
        private Bread bread = new Bread();

        public void Reset()
        {
            bread = new Bread();
        }

        public void AddSupplements()
        {
            bread.Supplements.Add("italian herbs");
        }

        public void SetFlour()
        {
            bread.Flour = "regular wheat";
        }

        public void SetSalt()
        {
            bread.Salt = 0.3;
        }

        public void SetWeight()
        {
            bread.Weight = 200;
        }

        public Bread GetProduct()
        {
            if (string.IsNullOrWhiteSpace(bread.Flour) && bread.Weight <= 0.5)
            {
                Console.WriteLine("Missed valid flour and weight.");
            }

            return bread;
        }
    }
}
