global using static PetClinic.Infrastructure.Common.DatabaseConstants.ReceptionistConstants;

namespace PetClinic.Infrastructure.Common.DatabaseConstants
{
    public static class ReceptionistConstants
    {
        public const int FirstNameMaxLengthForReceptionist = 35;
        public const int FirstNameMinLengthForReceptionist = 2;

        public const int LastNameMaxLengthForReceptionist = 35;
        public const int LastNameMinLengthForReceptionist = 2;

        public const int PhonenumberMaxLengthForReceptionist = 20;

        public const int JobDescriptionMaxLengthForReceptionist = 30;
        public const int JobDescriptionMinLengthForReceptionist = 5;
    }
}
