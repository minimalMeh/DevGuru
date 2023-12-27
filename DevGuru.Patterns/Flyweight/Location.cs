using DevGuru.Patterns.Flyweight.Entities;
using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Flyweight
{
    public class Location
    {
        private readonly List<House> houses = new();
        private readonly HouseFactory houseFactory = new();

        public void PlaceHouse(int x, int y, string layout)
        {
            var houseLayout = houseFactory.Get(layout);
            var house = new House(x, y, houseLayout);

            houses.Add(house);
        }

        public void DrawHouses()
        {
            Console.WriteLine("\nDraw houses on the map...");
            houses.ForEach(h => h.Draw());
        }
    }
}
