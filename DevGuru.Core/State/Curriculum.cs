using DevGuru.Core.State.Enums;
using System;
using System.Linq;

namespace DevGuru.Core.State
{
    public class Curriculum // context
    {
        private CurriculumState state;
        public string Subject { get; }

        public Curriculum(CurriculumState state, string subject)
        {
            Subject = subject;
            TransitionTo(state);
        }

        public void TransitionTo(CurriculumState state)
        {
            Console.WriteLine($"State for {Subject} is: {state.Level.GetString()}");
            this.state = state;
            state.SetCurriculum(this);
        }

        public void ShowPreparationInstruction()
        {
            var manual = state.GetManual(Subject);
            Console.WriteLine($"For exam preparation {state.Level.GetString()} level, {Subject} required next documents to learn:");
            manual.ToList().ForEach(f => Console.WriteLine('\t' + f.FullName + ";"));
        }

        public void ShowRequiredExams()
        {
            var sliceExam = state.GetSliceExam(Subject);
            var finalExam = state.GetFinalExam(Subject);

            if (sliceExam != null)
            {
                Console.WriteLine($"For {state.Level.GetString()} level, {Subject} the next tests should be passed:");
                sliceExam.ToList()?.ForEach(f => Console.WriteLine('\t' + f.FullName + ";"));
            }

            if (finalExam != null)
            {
                Console.WriteLine($"For {state.Level.GetString()} level, {Subject} the next tests should be passed:");
                finalExam.ToList()?.ForEach(f => Console.WriteLine('\t' + f.FullName + ";"));
            }
        }

        public bool Exam()
        {
            return state.PassExam();
        }
    }
}
