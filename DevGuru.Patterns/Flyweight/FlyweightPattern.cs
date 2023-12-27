using DevGuru.Core;
using DevGuru.Patterns.Flyweight.Constants;

namespace DevGuru.Patterns.Flyweight
{
    public class FlyweightPattern : BasePattern
    {
        public override string Name => "Flyweight";
        protected override string DescriptionFormatted => "\t[Minimizes RAM memory usage or computational expenses by sharing as much as possible with related objects,]\n\t[particularly useful when dealing with a large number of similar objects.]\n";
        protected override string IdeaFormatted => "\t[The game has a city with houses on the map. Every HouseLayout class has a corresponding]\n\t[bitmap image of the construction. Every House may have a similar HouseLayout structure.]\n\t[HouseFactory class 'caches' a house layout object and allows Houses with the same layout]\n\t[to share the HouseLayout object, reducing the memory.]\n";

        protected override void RunCore()
        {
            var location = new Location();

            location.PlaceHouse(0, 0, HouseLayoutType._1_201_6);
            location.PlaceHouse(0, 10, HouseLayoutType._1_201_12);
            location.PlaceHouse(0, 20, HouseLayoutType._1_201_13);
            location.PlaceHouse(0, 30, HouseLayoutType._1_201_6);
            location.PlaceHouse(0, 40, HouseLayoutType._1_207_7_Dormitory);
            location.PlaceHouse(10, 0, HouseLayoutType._1_207_7_Dormitory);
            location.PlaceHouse(20, 10, HouseLayoutType._1_207_7_Dormitory);
            location.PlaceHouse(30, 20, HouseLayoutType._1_207_7_Dormitory);
            location.PlaceHouse(40, 30, HouseLayoutType._1_201_6);

            location.DrawHouses();
        }
    }
}
