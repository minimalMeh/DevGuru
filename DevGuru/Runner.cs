﻿using System;
using System.IO;
using DevGuru.Core.AbstractFactory;
using DevGuru.Core.Adapter;
using DevGuru.Core.Bridge;
using DevGuru.Core.Bridge.Speakers;
using DevGuru.Core.Builder;
using DevGuru.Core.Compose;
using DevGuru.Core.Facade;
using DevGuru.Core.FactoryMethod;
using DevGuru.Core.Observer.Classic;
using DevGuru.Core.Observer.Classic.Subscribers;
using DevGuru.Core.Observer.Models;
using DevGuru.Core.State;
using DevGuru.Core.State.Levels;
using DevGuru.Core.TemplateMethod;
using File = DevGuru.Core.Compose.File;

namespace DevGuru
{
    public static class Runner
    {
        public static void Main(string [] args)
        {
            // Facade
            Client.Operation(new Facade(new Subsystem1(), new Subsystem2()));

            // Observer not C# sample, just observer, TODO: adequate c# event 
            //var ib = new InternetBilet();
            //var ba = new BusinessAffiche();
            //var tu = new TechnicalUniversity();
            //var rs = new RobotsSchool();

            //var eventMan = new EventManager();
            //eventMan.AttachAllEventsListener(ib);
            //eventMan.AttachBusinessListener(ba);
            //eventMan.AttachSienceListener(tu);
            //eventMan.AttachSienceListener(rs);

            //eventMan.AddBusinessEnvent(new BusinessEvent(DateTime.UtcNow, DateTime.UtcNow));
            //eventMan.AddSienceEnvent(new SienceEvent(DateTime.UtcNow, "Park Gorkogo"));
            //eventMan.AddSienceEnvent(new SienceEvent(DateTime.UtcNow, "Jellyfish museum"));

            //ib.Print();
            //ba.Print();
            //tu.Print();
            //rs.Print();

            // Compose
            //var compose = new FileSystem();
            //var root = new Folder("C:");
            //var folderA = new Folder("Alpha");
            //compose.Add(root, folderA);
            //var fileA = new File("Apartments.doc", 124);
            //compose.Add(folderA, fileA);
            //var folderB = new Folder("Beta");
            //compose.Add(root, folderB);
            //compose.Add(folderB, new File("Bye", 1064));
            //var fileB1 = new File("Bike.img", 300);
            //compose.Add(folderB, fileB1);
            //var fileR = new File("RootFile.db", 20000);
            //compose.Add(root, fileR);
            //Console.WriteLine(compose.GetSize(root));

            // Builder
            //var bakery = new Bakery();
            //var crsntBuilder = new СroissantBuilder();
            //bakery.Bake(crsntBuilder);
            //Console.WriteLine(crsntBuilder.GetProduct().ToString());
            //var bgtBuilder = new BaguetteBuilder();
            //bakery.Bake(bgtBuilder);
            //Console.WriteLine(bgtBuilder.GetProduct().ToString()); 


            // Factory method
            //var dialogService = new DialogService();
            //dialogService.Initialize("windows");
            //dialogService.Render();
            //dialogService.Initialize("web");
            //dialogService.Render();

            // Abstract factory
            //GUIService.SimulateGUI("windows");
            //GUIService.SimulateGUI("goofy");
            //GUIService.SimulateGUI("mac");

            // Bridge
            //var control = new PhoneRemoteControl();
            //var speaker = new ConcertHallSpeaker();
            //speaker.PairDevice(control);
            //speaker.TurnOn();
            //speaker.TurnOff();
            //speaker.PairDevice(new ControlPanel("poroshenko"));
            //speaker.TurnOn();
            //speaker.TurnOff();

            // Adapter
            //IDiagnosisService adapter = new DiagnosisService(new LegacyXRayService("Back"));
            //adapter.Print();

            // State
            //var context = new Curriculum(new BegginerLevel(), "Math");
            //context.ShowPreparationInstruction();
            //context.ShowRequiredExams();
            //if (context.Exam())
            //{
            //    context.TransitionTo(new IntermediateLevel());
            //    context.ShowPreparationInstruction();
            //    context.ShowRequiredExams();
            //    if (context.Exam())
            //    {
            //        context.TransitionTo(new AdvancedLevel());
            //        context.ShowPreparationInstruction();
            //        context.ShowRequiredExams();
            //    }
            //}

            //context = new Curriculum(new IntermediateLevel(), "Chemistry");
            //context.ShowRequiredExams();
            //if (context.Exam())
            //{
            //    context.TransitionTo(new AdvancedLevel());
            //}

            // TemplateMethod
            //var passport = new FileInfo("diya\\passport.txt");
            //var inn = new FileInfo("inn.txt");
            //var eSign = new FileInfo("diya\\key.dat");
            //EntrepreneurClient.SendRequestToBeEntrepreneur(new DiyaEntrepreneurService(), passport, inn, eSign);
            //EntrepreneurClient.SendRequestToBeEntrepreneur(new NotaryEnrepreneurService(), passport, inn);

            // Strategy
            //int [] array = { 1, 2, 3, 12, 312, 312, 12, 2, 3, 34, 5, 35, 2, 3, 24, 23, 31, 24, 235, 346, 4, 2, 3, 4 };
            //string [] array2 = { "lox", "LAH", "HAHAHAH", "SASAT" , "d", "manchester", "no", "yes" , "dasha" };
            //char [] array3 = { 'd', 'a', '2' , 'l', 'G', 'A', 'U', 'u' };

            //var intSortMachine = new SortMachine<int>();
            //var stringSortMachine = new SortMachine<string>();
            //var charSortMachine = new SortMachine<char>();

            //intSortMachine.SetStrategy(new BubbleSort<int>());
            //stringSortMachine.SetStrategy(new SelectionSort<string>());

            //intSortMachine.Sort(array);
            //stringSortMachine.Sort(array2);

            //intSortMachine.SetStrategy(new SelectionSort<int>());
            //stringSortMachine.SetStrategy(new BubbleSort<string>());

            //intSortMachine.Sort(array);
            //stringSortMachine.Sort(array2);

            //charSortMachine.SetStrategy(new BubbleSort<char>());
            //charSortMachine.Sort(array3);

            // FlyWeight
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
