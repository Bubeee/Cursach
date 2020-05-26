using System.Collections.Generic;
using Coursach.Entities;

namespace Coursach.Calculators
{
    public class CoeffCalulator
    {
        public decimal GetCoefficient(User user)
        {
            var result = 1.0m;

            var average = AverageMark(user.Marks);

            if (average < 5)
            {
                return 0;
            }

            if (user.HasParticipatedInSocialEvents)
            {
                result += 0.25m;
            }

            if (average > 8)
            {
                result += 0.25m;
            }

            return result;
        }

        private double AverageMark(List<Mark> marks)
        {
            var marksSum = 0;
            var marksCount = 0;
            foreach (var userMark in marks)
            {
                if (userMark is ExamMark mark)
                {
                    marksSum += mark.Value;
                    marksCount++;
                }
            }

            return marksCount == 0 ? 0 : marksSum / marksCount;
        }
    }
}