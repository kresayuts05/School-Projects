using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Infrastructure.Data.Constants
{
    public static class ModelConstraints
    {
        public static class UserConstants
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 2;

            public const int AddressMaxLength = 100;
            public const int AddressMinLength = 5;

            public const int CityMaxLength = 169;
            public const int CityMinLength = 1;

            public const int CountryMaxLength = 56;
            public const int CountryMinLength = 4;

            public const int EmailMaxLength = 50;
            public const int EmailMinLength = 10;
        }

        public static class FirmConstants
        {
            public const int SalaryMaxValue = 50;
            public const int SalaryMinValue = 2;
        }

        public static class ProgrammerConstants
        {
            public const int ShortDescriptionMaxLength = 1000;
            public const int ShortDescriptionMinLength = 5;
        }

        public static class PostConstants
        {
            public const int TitleMaxLength = 30;
            public const int TitleMinLength = 5;

            public const int HiringPositionMaxLength = 20;
            public const int HiringPositionMinLength = 5;

            public const int BenefitsMaxLength = 500;
            public const int BenefitsMinLength = 5;

            public const string SalaryMaxValue = "25000";
            public const string SalaryMinValue = "640";

            public const string WorkingHoursMaxValue = "16";
            public const string WorkingHoursMinValue = "4";

            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 20;
        }
    }
}
