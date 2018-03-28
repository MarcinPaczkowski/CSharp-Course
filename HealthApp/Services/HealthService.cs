using HealthApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Services
{
    public class HealthService
    {
        public HealthType GetHealthTypeByWeight(int weight)
        {
            if (IsNegativeOrZero(weight))
            {
                throw new Exception("Weight should be positive number!");
            }

            if (IsVeryGood(weight))
            {
                return HealthType.VeryGood;
            }

            if (IsGood(weight))
            {
                return HealthType.Good;
            }

            if (IsCommon(weight))
            {
                return HealthType.Common;
            }

            if (IsBad(weight))
            {
                return HealthType.Bad;
            }

            if (IsVeryBad(weight))
            {
                return HealthType.VeryBad;
            }

            return HealthType.Common;
        }

        private static bool IsVeryBad(int weight)
        {
            return (weight >= 44 && weight <= 85);
        }

        private static bool IsBad(int weight)
        {
            return (weight >= 45 && weight <= 49) || (weight >= 80 && weight <= 84);
        }

        private static bool IsCommon(int weight)
        {
            return (weight >= 50 && weight <= 54) || (weight >= 75 && weight <= 79);
        }

        private static bool IsGood(int weight)
        {
            return (weight >= 55 && weight <= 59) || (weight >= 71 && weight <= 74);
        }

        private static bool IsVeryGood(int weight)
        {
            return weight >= 60 && weight <= 70;
        }

        private bool IsNegativeOrZero(int weight)
        {
            return weight <= 0;
        }
    }
}