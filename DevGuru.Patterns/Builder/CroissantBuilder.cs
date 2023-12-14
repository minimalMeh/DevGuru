using System;

namespace DevGuru.Patterns.Builder
{
    public class CroissantBuilder : IBakingBuilder
    {
        private Bread bread = new();

        public CroissantBuilder()
        {
            Console.WriteLine($"{nameof(CroissantBuilder)}: Inititalizing");
        }

        public void Reset()
        {
            Console.WriteLine($"{nameof(CroissantBuilder)}: Reset");
            bread = new Bread();
        }

        public void AddSupplements()
        {
            Console.WriteLine($"{nameof(CroissantBuilder)}: Add Supplements");
            bread.Supplements.Add("sesame");
            bread.Supplements.Add("powdered sugar");
        }

        public void SetFlour()
        {
            Console.WriteLine($"{nameof(CroissantBuilder)}: Set Flour");
            bread.Flour = "soft wheat";
        }

        public void SetSalt()
        {
            Console.WriteLine($"{nameof(CroissantBuilder)}: Set Salt");
            bread.Salt = 0.2;
        }

        public void SetWeight()
        {
            Console.WriteLine($"{nameof(CroissantBuilder)}: Set Weight");
            bread.Weight = 150;
        }

        public Bread GetProduct()
        {
            if (string.IsNullOrWhiteSpace(bread.Flour) && bread.Weight <= 0.5)
            {
                Console.WriteLine($"{nameof(CroissantBuilder)}: Warining during getting the product - Missed valid flour and weight.");
            }

            return bread;
        }
    }
}
