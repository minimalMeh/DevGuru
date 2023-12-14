﻿using DevGuru.Core.Flyweight.Entities;
using System;
using System.Collections.Generic;

namespace DevGuru.Core.Flyweight
{
    public class HouseFactory
    {
        private readonly Lazy<Dictionary<string, HouseLayout>> houseLayouts = new Lazy<Dictionary<string, HouseLayout>>();

        private Dictionary<string, HouseLayout> HouseLayouts { get => houseLayouts.Value; }

        public HouseLayout Get(string layout)
        {
            HouseLayouts.TryGetValue(layout, out HouseLayout houseLayout);

            if (houseLayout == null)
            {
                houseLayout = new HouseLayout(layout);
                HouseLayouts.Add(layout, houseLayout);
            }

            Console.WriteLine($"Returned HouseLayout with type: {layout}");
            return houseLayout;
        }
    }
}
