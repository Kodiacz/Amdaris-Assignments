﻿global using static PetCare.Infrastructure.Common.DatabaseConstants.DoctorConstants;

namespace PetCare.Infrastructure.Common.DatabaseConstants
{
    public static class DoctorConstants
    {
        public const int FirstNameMaxLengthForDoctor = 35;
        public const int FirstNameMinLengthForDoctor = 2;

        public const int LastNameMaxLengthForDoctor = 35;
        public const int LastNameMinLengthForDoctor = 2;

        public const int AgeMinLengthForDoctor = 1;

        public const int PhonenumberMaxLengthForDoctor = 20;

        public const int JobDescriptionMaxLengthForDoctor = 400;
        public const int JobDescriptionMinLengthForDoctor = 5;
    }
}
