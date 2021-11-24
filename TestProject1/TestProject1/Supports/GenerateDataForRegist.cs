using System;

namespace TestProject1.Supports
{
    public static class GenerateDataForRegist
    {
       internal const string defaultPassword = "Test1234";
       internal static string GenerateMail()
        {
            string tempMail = "test";
            tempMail += (DateTime.Now.ToBinary() * -1 + "@gmail.com");
            return tempMail;
        }
    }
}
