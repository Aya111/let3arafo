using System;

namespace SK.Framework
{
    public enum SupportedLanguage
    {
        None,
        Arabic,
        English
    }

    public static class SupportedLanguageExtensions
    {
        public static string Code(this SupportedLanguage self)
        {
            if (self == SupportedLanguage.Arabic)
                return "ar";
            else
                return "en";
        }

        public static SupportedLanguage ToSupportedLang(this string self)
        {
            if (self.Equals("ar", StringComparison.InvariantCultureIgnoreCase))
                return SupportedLanguage.Arabic;

            if (self.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                return SupportedLanguage.English;

            return SupportedLanguage.None;
        }
    }
}