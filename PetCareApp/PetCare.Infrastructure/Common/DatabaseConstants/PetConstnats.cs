﻿global using static PetCare.Infrastructure.Common.DatabaseConstants.PetConstnats;

namespace PetCare.Infrastructure.Common.DatabaseConstants
{
    public static class PetConstnats
    {
        public const int NameMaxLengthForPet = 35;
        public const int NameMinLengthForPet = 2;

        public const int BreedMaxLengthForPet = 20;
        public const int BreedMinLengthForPet = 1;

        public const int AgeMinLengthForPet = 1;

        public const int TypeMaxLengthForPet = 20;
        public const int TypeMinLengthForPet = 1;
    }
}
