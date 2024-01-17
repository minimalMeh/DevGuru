using DevGuru.Patterns.State.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DevGuru.Patterns.State.Levels
{
    public class BegginerLevel : CurriculumState
    {
        public override Level Level => Level.Begginer;
        public override bool ExamPassed => new Random().Next(1, 3) != 0;

        public override IEnumerable<FileInfo> GetManual(string subject)
        {
            return new List<FileInfo>
            {
                new($"{subject.ToLowerInvariant()}\\begginers\\manual\\theory.doc")
            };
        }

        public override IEnumerable<FileInfo> GetFinalExam(string subject)
        {
            return new List<FileInfo>
            {
                new($"{subject.ToLowerInvariant()}\\begginers\\final\\theory.doc")
            };
        }

        public override IEnumerable<FileInfo> GetSliceExam(string subject)
        {
            return Enumerable.Empty<FileInfo>();
        }
    }
}
