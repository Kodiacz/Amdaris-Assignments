namespace PetClinic.Infrastructure.Common.HelperMethods
{
    using System.Text;

    public static class PhoneGenerator
    {
        private static int LandLinePhoneLength = 7;
        private static int MobilePhoneLength = 10;

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
