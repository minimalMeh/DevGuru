using DevGuru.Patterns.State.Enums;
using System;
using System.Collections.Generic;
using System.IO;

namespace DevGuru.Patterns.State.Levels
{
    public class AdvancedLevel : CurriculumState
    {
        public override Level Level => Level.Advanced;
        public override bool ExamPassed => new Random().Next(1, 5) != 0;

        public override IEnumerable<FileInfo> GetManual(string subject)
        {
            return new List<FileInfo>
            {
                new($"{subject.ToLowerInvariant()}\\advanced\\manual\\theory.doc"),
                new($"{subject.ToLowerInvariant()}\\advanced\\manual\\articles.doc"),
                new($"{subject.ToLowerInvariant()}\\advanced\\manual\\taskexample.doc")
            };
        }

        public override IEnumerable<FileInfo> GetFinalExam(string subject)
        {
            return new List<FileInfo>
            {
                new($"{subject.ToLowerInvariant()}\\advanced\\final\\practice1.doc"),
                new($"{subject.ToLowerInvariant()}\\advanced\\final\\practice2.doc"),
                new($"{subject.ToLowerInvariant()}\\advanced\\final\\testtask.doc"),
            };
        }

        public override IEnumerable<FileInfo> GetSliceExam(string subject)
        {
            return new List<FileInfo>
            {
                new($"{subject.ToLowerInvariant()}\\advanced\\slice\\patenttest.doc"),
            };
        }
    }
}
