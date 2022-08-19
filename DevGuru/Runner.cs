﻿using System;
using System.Linq;
using DevGuru.Core.Flyweight;
using DevGuru.Core.Flyweight.Constants;
using DevGuru.Core.Strategy;
using DevGuru.Core.Strategy.Concrete;

namespace DevGuru
{
    public static class Runner
    {
        public static void Main(string [] args)
        {
            int [] array = { 1, 2, 3, 12, 312, 312, 12, 2, 3, 34, 5, 35, 2, 3, 24, 23, 31, 24, 235, 346, 4, 2, 3, 4 };
            string [] array2 = { "lox", "LAH", "HAHAHAH", "SASAT" , "d", "manchester", "no", "yes" , "dasha" };
            char [] array3 = { 'd', 'a', '2' , 'l', 'G', 'A', 'U', 'u' };

            var intSortMachine = new SortMachine<int>();
            var stringSortMachine = new SortMachine<string>();
            var charSortMachine = new SortMachine<char>();

            intSortMachine.SetStrategy(new BubbleSort<int>());
            stringSortMachine.SetStrategy(new SelectionSort<string>());

            intSortMachine.Sort(array);
            stringSortMachine.Sort(array2);

            intSortMachine.SetStrategy(new SelectionSort<int>());
            stringSortMachine.SetStrategy(new BubbleSort<string>());

            intSortMachine.Sort(array);
            stringSortMachine.Sort(array2);

            charSortMachine.SetStrategy(new BubbleSort<char>());
            charSortMachine.Sort(array3);

            //var location = new Location();

            //location.BuildHouse(0, 0, HouseLayoutType._1_201_6);
            //location.BuildHouse(0, 10, HouseLayoutType._1_201_12);
            //location.BuildHouse(0, 20, HouseLayoutType._1_201_13);
            //location.BuildHouse(0, 30, HouseLayoutType._1_201_6);
            //location.BuildHouse(0, 40, HouseLayoutType._1_207_7_Dormitory);
            //location.BuildHouse(10, 0, HouseLayoutType._1_207_7_Dormitory);
            //location.BuildHouse(20, 10, HouseLayoutType._1_207_7_Dormitory);
            //location.BuildHouse(30, 20, HouseLayoutType._1_207_7_Dormitory);
            //location.BuildHouse(40, 30, HouseLayoutType._1_201_6);

            //location.DrawHouses();
        }
    }
}
