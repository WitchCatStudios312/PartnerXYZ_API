namespace PartnerXYZ_API
{
    public class Utilities
    {
        public static string GetData()
        {
            string fileName = @"C:\Users\lvanv\Desktop\Code Challenges\PartnerXYZ_API\PartnerXYZ_API\PartnerXYZRates.json";

            string jsonString = File.ReadAllText(fileName);

            return jsonString;
        }
    }
}
