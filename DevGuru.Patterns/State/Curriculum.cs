using DevGuru.Patterns.State.Enums;
using System;
using System.Linq;

namespace DevGuru.Patterns.State
{
    public class Curriculum
    {
        private CurriculumState state;
        public string SubjectName { get; }

        public Curriculum(CurriculumState state, string subject)
        {
            SubjectName = subject;
            TransitionTo(state);
        }

        public void TransitionTo(CurriculumState state)
        {
            Console.WriteLine($"\n***[{SubjectName}] Level {state.Level.GetName()}.***");
            this.state = state;
            state.SetCurriculum(this);
        }

        public void PrintPlanInfo()
        {
            Console.WriteLine($"[{SubjectName}] {state.Level.GetName()} study plan:");

            var manual = state.GetManual(SubjectName);

            if (manual.Any())
            {
                Console.WriteLine("Document(s) to study:");
                manual.ToList().ForEach(f => Console.WriteLine('\t' + f.FullName + ";"));
            }
            else
            {
                Console.WriteLine("No required document(s).");
            }
        }

        public void PrintExamsInfo()
        {
            Console.WriteLine($"[{SubjectName}] {state.Level.GetName()} test plan:");

            var sliceExams = state.GetSliceExam(SubjectName);
            var finalExams = state.GetFinalExam(SubjectName);

            if (sliceExams.Any())
            {
                Console.WriteLine("Slice test(s) to pass:");
                sliceExams.ToList().ForEach(f => Console.WriteLine('\t' + f.FullName + ";"));
            }

            if (finalExams.Any())
            {
                Console.WriteLine("Final test(s) to pass:");
                finalExams.ToList().ForEach(f => Console.WriteLine('\t' + f.FullName + ";"));
            }

            if (!sliceExams.Any() && !finalExams.Any())
            {
                Console.WriteLine("No required test(s).");
            }
        }

        public bool Exam()
        {
            return state.ExamPassed;
        }
    }
}
