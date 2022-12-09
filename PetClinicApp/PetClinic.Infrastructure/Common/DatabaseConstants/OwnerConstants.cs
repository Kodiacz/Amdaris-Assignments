global using static PetClinic.Infrastructure.Common.DatabaseConstants.OwnerConstants;
global using static PetClinic.Infrastructure.Common.HelperMethods.PhoneGenerator;

namespace PetClinic.Infrastructure.Common.DatabaseConstants
{
    public static class OwnerConstants
    {
        public const int FirstNameMaxLengthForOwner = 35;
        public const int FirstNameMinLengthForOwner = 2;

        public const int LastNameMaxLengthForOwner = 35;
        public const int LastNameMinLengthForOwner = 2;

        public const int AgeMinLengthForOwner = 1;

        public const int PhonenumberMaxLengthForOwner = 20;
    }
}
