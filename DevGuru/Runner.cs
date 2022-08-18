using DevGuru.Core.Flyweight;
using DevGuru.Core.Flyweight.Constants;

namespace DevGuru
{
    public static class Runner
    {
        public static void Main(string [] args)
        {
            var location = new Location();

            location.BuildHouse(0, 0, HouseLayoutType._1_201_6);
            location.BuildHouse(0, 10, HouseLayoutType._1_201_12);
            location.BuildHouse(0, 20, HouseLayoutType._1_201_13);
            location.BuildHouse(0, 30, HouseLayoutType._1_201_6);
            location.BuildHouse(0, 40, HouseLayoutType._1_207_7_Dormitory);
            location.BuildHouse(10, 0, HouseLayoutType._1_207_7_Dormitory);
            location.BuildHouse(20, 10, HouseLayoutType._1_207_7_Dormitory);
            location.BuildHouse(30, 20, HouseLayoutType._1_207_7_Dormitory);
            location.BuildHouse(40, 30, HouseLayoutType._1_201_6);

            location.DrawHouses();
        }
    }
}
