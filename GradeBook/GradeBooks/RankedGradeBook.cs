using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }

            switch (averageGrade)
            {
                case double n when n >= 80:
                    return 'A';
                case double n when n >= 60:
                    return 'A';
                case double n when n >= 40:
                    return 'A';
                case double n when n >= 20:
                    return 'A';
                default:
                    return 'F';
            }
        }
    }
}