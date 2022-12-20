global using static PetCare.Infrastructure.Common.HelperMethods.PhoneGenerator;

namespace PetCare.Infrastructure.Common.HelperMethods
{
    using System.Text;

    public static class PhoneGenerator
    {
        private static int LandLinePhoneLength = 7;
        private static int MobilePhoneLength = 10;

        /// <summary>
        /// Generates a Landline phone number, specifically for Bulgaria,
        /// which stasrts with 02 and is 7 digit long. 
        /// It is using the Random method and StrinBuilder
        /// </summary>
        /// <returns>string that contains the generated Landline phonenumber</returns>
        public static string GenerateLandlinePhone()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            sb.Append("02");

            for (int i = 0; i < LandLinePhoneLength - 2; i++)
            {
                sb.Append(random.Next(10));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Generates a Mobile phone number, specifically for Bulgaria,
        /// which stasrts with 087, 088 or 089 and is 10 digit long. 
        /// It is using the Random method and StrinBuilder
        /// </summary>
        /// <returns>string that contains the generated Mobil ephonenumber</returns>
        public static string GenerateMobilePhone()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            sb.Append("08");
            sb.Append(random.Next(7, 10));

            for (int i = 0; i < MobilePhoneLength - 3; i++)
            {
                sb.Append(random.Next(10).ToString());
            }

            return sb.ToString();
        }
    }
}
