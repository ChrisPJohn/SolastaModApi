using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SubtitleOccurenceDescription))]
    public static partial class SubtitleOccurenceDescriptionExtensions
    {
        public static T SetEndSecond<T>(this T entity, float value)
            where T : SubtitleOccurenceDescription
        {
            entity.SetField("endSecond", value);
            return entity;
        }

        public static T SetLocKey<T>(this T entity, string value)
            where T : SubtitleOccurenceDescription
        {
            entity.SetField("locKey", value);
            return entity;
        }

        public static T SetStartSecond<T>(this T entity, float value)
            where T : SubtitleOccurenceDescription
        {
            entity.SetField("startSecond", value);
            return entity;
        }
    }
}