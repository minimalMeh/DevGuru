using DevGuru.Patterns.Flyweight.Entities;
using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Flyweight
{
    public class HouseFactory
    {
        private readonly Lazy<Dictionary<string, HouseLayout>> houseLayouts = new();

        private Dictionary<string, HouseLayout> HouseLayouts { get => houseLayouts.Value; }

        public HouseLayout Get(string layout)
        {
            HouseLayouts.TryGetValue(layout, out HouseLayout houseLayout);

            if (houseLayout == null)
            {
                houseLayout = new HouseLayout(layout);
                HouseLayouts.Add(layout, houseLayout);
                Console.WriteLine($"Generating HouseLayout [{layout}]...");
            }

            return houseLayout;
        }
    }
}
