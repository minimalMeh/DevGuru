using System;

namespace DevGuru.Patterns.Builder
{
    public class BaguetteBuilder : IBakingBuilder
    {
        private Bread bread = new();

        public BaguetteBuilder()
        {
            Console.WriteLine($"{nameof(BaguetteBuilder)}: Inititalizing");
        }

        public void Reset()
        {
            Console.WriteLine($"{nameof(BaguetteBuilder)}: Reset");
            bread = new Bread();
        }

        public void AddSupplements()
        {
            Console.WriteLine($"{nameof(BaguetteBuilder)}: Add Supplements");
            bread.Supplements.Add("italian herbs");
        }

        public void SetFlour()
        {
            Console.WriteLine($"{nameof(BaguetteBuilder)}: Set Flour");
            bread.Flour = "regular wheat";
        }

        public void SetSalt()
        {
            Console.WriteLine($"{nameof(BaguetteBuilder)}: Set Salt");
            bread.Salt = 0.3;
        }

        public void SetWeight()
        {
            Console.WriteLine($"{nameof(BaguetteBuilder)}: Set Weight");
            bread.Weight = 200;
        }

        public Bread GetProduct()
        {
            if (string.IsNullOrWhiteSpace(bread.Flour) && bread.Weight <= 0.5)
            {
                Console.WriteLine($"{nameof(BaguetteBuilder)}: Warining during getting the product - Missed valid flour and weight.");
            }

            return bread;
        }
    }
}
