using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class NarrativeEventDescriptionExtensions
    {
        public static T SetOccurenceWeight<T>(this T entity, int value)
            where T : NarrativeEventDescription
        {
            entity.SetField("occurenceWeight", value);
            return entity;
        }

        public static T SetQuote<T>(this T entity, string value)
            where T : NarrativeEventDescription
        {
            entity.SetField("quote", value);
            return entity;
        }
    }
}