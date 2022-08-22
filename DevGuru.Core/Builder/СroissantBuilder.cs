using System;

namespace DevGuru.Core.Builder
{
    public class СroissantBuilder : IBakingBuilder
    {
        private Bread bread = new Bread();

        public void Reset()
        {
            bread = new Bread();
        }

        public void AddSupplements()
        {
            bread.Supplements.Add("sesame");
            bread.Supplements.Add("powdered sugar");
        }

        public void SetFlour()
        {
            bread.Flour = "soft wheat";
        }

        public void SetSalt()
        {
            bread.Salt = 0.2;
        }

        public void SetWeight()
        {
            bread.Weight = 150;
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
