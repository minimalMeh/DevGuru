using System;
using System.Collections.Generic;
using System.IO;
using DevGuru.Core.State.Enums;

namespace DevGuru.Core.State.Levels
{
    public class BegginerLevel : CurriculumState
    {
        public override Level Level => Level.Begginer;

        public override bool PassExam()
        {
            var rand = new Random().Next(1, 3);
            return rand % 2 != 0;
        }

        public override IEnumerable<FileInfo> GetFinalExam(string subject)
        {
            return new List<FileInfo>
            {
                new FileInfo($"{subject.ToLowerInvariant()}\\begginers\\final\\theory.doc")
            };
        }

        public override IEnumerable<FileInfo> GetManual(string subject)
        {
            return new List<FileInfo>
            {
                new FileInfo($"{subject.ToLowerInvariant()}\\begginers\\manual\\theory.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\begginers\\manual\\practice.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\begginers\\manual\\articles.doc"),
            };
        }

        public override IEnumerable<FileInfo> GetSliceExam(string subject)
        {
            return null;
        }
    }
}
