using System.Globalization;
using System.Threading;

namespace SK.Framework
{
    public static class Env
    {
        public static bool IsArabic(string lang)
        {
            return lang == "ar";
        }

        public static bool IsArabic()
        {
            bool isArabic = Thread.CurrentThread.CurrentCulture.Name == "ar-EG";
            return isArabic;
        }

        public static bool IsUKEnglish()
        {
            bool isUKEnglish = Thread.CurrentThread.CurrentCulture.Name == "en-GB";
            return isUKEnglish;
        }

        public static bool IsUSEnglish()
        {
            bool isUSEnglish = Thread.CurrentThread.CurrentCulture.Name == "en-US";
            return isUSEnglish;
        }

        public static bool IsFrench(string code)
        {
            return code?.Equals("fr", System.StringComparison.InvariantCulture) ?? false;
        }

        public static bool IsFrench()
        {
            bool isFrench = Thread.CurrentThread.CurrentCulture.Name == "fr-FR";
            return isFrench;
        }

        public static void SetArabic()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-EG");
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ar-EG");
        }

        public static void SetUKEnglish()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
        }

        public static void SetUSEnglish()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        }

        public static string CurrentCultureCode => Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
    }
}