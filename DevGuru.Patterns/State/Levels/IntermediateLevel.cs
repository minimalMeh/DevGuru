using DevGuru.Patterns.State.Enums;
using System;
using System.Collections.Generic;
using System.IO;

namespace DevGuru.Patterns.State.Levels
{
    public class IntermediateLevel : CurriculumState
    {
        public override Level Level => Level.Intermediate;

        public override bool PassExam()
        {
            var rand = new Random().Next(1, 4);
            return rand % 2 != 0;
        }

        public override IEnumerable<FileInfo> GetFinalExam(string subject)
        {
            return new List<FileInfo>
            {
                new FileInfo($"{subject.ToLowerInvariant()}\\middle\\teoryandpractice.doc"),
            };
        }

        public override IEnumerable<FileInfo> GetManual(string subject)
        {
            return new List<FileInfo>
            {
                new FileInfo($"{subject.ToLowerInvariant()}\\middle\\manual\\theory.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\middle\\manual\\practice.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\middle\\manual\\articles.doc"),
            };
        }

        public override IEnumerable<FileInfo> GetSliceExam(string subject)
        {
            return new List<FileInfo>
            {
                new FileInfo($"{subject.ToLowerInvariant()}\\begginers\\final\\theory.doc"),
                new FileInfo($"{subject.ToLowerInvariant()}\\begginers\\final\\practice.doc"),
            };
        }
    }
}
