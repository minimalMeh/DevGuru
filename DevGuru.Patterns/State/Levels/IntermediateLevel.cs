using DevGuru.Patterns.State.Enums;
using System;
using System.Collections.Generic;
using System.IO;

namespace DevGuru.Patterns.State.Levels
{
    public class IntermediateLevel : CurriculumState
    {
        public override Level Level => Level.Intermediate;
        public override bool ExamPassed => new Random().Next(1, 4) % 2 != 0;

        public override IEnumerable<FileInfo> GetManual(string subject)
        {
            return new List<FileInfo>
            {
                new($"{subject.ToLowerInvariant()}\\middle\\manual\\theory.doc"),
                new($"{subject.ToLowerInvariant()}\\middle\\manual\\practice.doc"),
            };
        }

        public override IEnumerable<FileInfo> GetFinalExam(string subject)
        {
            return new List<FileInfo>
            {
                new($"{subject.ToLowerInvariant()}\\middle\\teoryandpractice.doc"),
            };
        }

        public override IEnumerable<FileInfo> GetSliceExam(string subject)
        {
            return new List<FileInfo>
            {
                new($"{subject.ToLowerInvariant()}\\begginers\\slice\\theory.doc"),
            };
        }
    }
}
