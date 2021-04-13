using I2.Loc;

namespace SolastaModApi
{
    public class LocalizationHelper
    {

        public static string AddString(string key, string translation)
        {
            LanguageSourceData languageData = LocalizationManager.Sources[0];
            TermData termData = languageData.AddTerm(key);
            termData.Languages[languageData.GetLanguageIndex("English")] = translation;
            return key;
        }
    }
}
