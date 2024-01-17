using DevGuru.Patterns.State.Enums;
using System.Collections.Generic;
using System.IO;

namespace DevGuru.Patterns.State
{
    public abstract class CurriculumState
    {
        protected Curriculum curriculum;

        public abstract Level Level { get; }
        public abstract bool ExamPassed { get; }

        public abstract IEnumerable<FileInfo> GetSliceExam(string subject);
        public abstract IEnumerable<FileInfo> GetFinalExam(string subject);
        public abstract IEnumerable<FileInfo> GetManual(string subject);

        public void SetCurriculum(Curriculum curriculum)
        {
            this.curriculum = curriculum;
        }
    }
}
