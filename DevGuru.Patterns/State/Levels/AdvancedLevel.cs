using DevGuru.Patterns.State.Enums;
using System;
using System.Collections.Generic;
using System.IO;

namespace DevGuru.Patterns.State.Levels
{
    public class AdvancedLevel : CurriculumState
    {
        public override Level Level => Level.Advanced;

        public override bool PassExam()
        {
            var rand = new Random().Next(1, 5);
            return rand % 2 != 0;
        }

        public override IEnumerable<FileInfo> GetFinalExam(string subject)
        {
            return new List<FileInfo>
            {
                new FileInfo($"{subject.ToLowerInvariant()}\\advanced\\final\\practice1.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\advanced\\final\\practice2.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\advanced\\final\\patenttest.doc"),
            };
        }

        public override IEnumerable<FileInfo> GetManual(string subject)
        {
            return new List<FileInfo>
            {
                new FileInfo($"{subject.ToLowerInvariant()}\\advanced\\manual\\theory.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\advanced\\manual\\articles.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\advanced\\manual\\patentsample.doc")
            };
        }

        public override IEnumerable<FileInfo> GetSliceExam(string subject)
        {
            return new List<FileInfo>
            {
                new FileInfo($"{subject.ToLowerInvariant()}\\advanced\\slice\\patenttest.doc"),
            };
        }
    }
}
