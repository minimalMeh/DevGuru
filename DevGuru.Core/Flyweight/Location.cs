using System;
using System.Collections.Generic;
using System.Text;
using DevGuru.Core.Flyweight.Entities;

namespace DevGuru.Core.Flyweight
{
    public class Location
    {
        private readonly List<House> houses = new List<House>();
        private readonly HouseFactory houseFactory = new HouseFactory();

        public void BuildHouse(int x, int y, string layout)
        {
            var houseLayout = houseFactory.Get(layout);
            var house = new House(x, y, houseLayout);

            houses.Add(house);
        }

        public void DrawHouses()
        {
            houses.ForEach(h => h.Draw());
        }
    }
}
