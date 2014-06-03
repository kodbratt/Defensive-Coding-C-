using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void ValidateEmail()
        {
            throw new NotImplementedException();
        }

        //public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        //{
        //    decimal result = 0;

        //    decimal goalStepCount = 0;
        //    decimal.TryParse(goalSteps, out goalStepCount);

        //    decimal actualStepsCount = 0;
        //    decimal.TryParse(actualSteps, out actualStepsCount);

        //    if(goalStepCount > 0)
        //    {
        //        result = (actualStepsCount / goalStepCount) * 100;
        //    }

        //    return result;
        //}

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {

            decimal goalStepCount = 0;
            decimal actualStepsCount = 0;
            //hello

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Steps must be entered");

            decimal.TryParse(goalSteps, out goalStepCount);

            decimal.TryParse(actualSteps, out actualStepsCount);

            return CalculatePercentOfGoalSteps(actualStepsCount, goalStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalSteps, decimal actualSteps)
        {
            if (goalSteps <= 0) throw new ArgumentException("Goal must be greatet then zero");
            return (actualSteps / goalSteps) * 100;
        }
    }
}
