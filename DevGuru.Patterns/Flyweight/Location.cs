using DevGuru.Patterns.Flyweight.Entities;
using System.Collections.Generic;

namespace DevGuru.Patterns.Flyweight
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
