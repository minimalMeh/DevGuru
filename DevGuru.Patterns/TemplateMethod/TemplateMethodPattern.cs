using DevGuru.Core;
using System;
using System.IO;

namespace DevGuru.Patterns.TemplateMethod
{
    public class TemplateMethodPattern : PatternBase
    {
        public override string Name => "Template Method";
        protected override string DescriptionFormatted => "\t[Defines the skeleton of an algorithm in the superclass but lets subclasses override]\n\t[specific steps of the algorithm without changing its structure.]\n";
        protected override string IdeaFormatted => "\t[To send a request to become an induvidual enterpreneur you may either]\n\t[the DIYA validation service or the Notary.]\n";

        protected override void RunCore()
        {
            var passport = new FileInfo("passport.img");
            var inn = new FileInfo("inn.img");
            var eSign = new FileInfo("key.dat");
            Console.WriteLine("---------");
            EntrepreneurClient.SendRequestToBeEntrepreneur(new DiyaEntrepreneurService(), passport, inn, eSign);
            Console.WriteLine("---------");
            EntrepreneurClient.SendRequestToBeEntrepreneur(new NotaryEnrepreneurService(), passport, inn);
            Console.WriteLine("---------");
        }
    }
}
