using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SubtitleTableDefinition))]
    public static class SubtitleTableDefinitionExtensions
    {
        public static T SetLineHeight<T>(this T entity, float value)
            where T : SubtitleTableDefinition
        {
            entity.SetField("lineHeight", value);
            return entity;
        }

        public static T SetLineSpacing<T>(this T entity, float value)
            where T : SubtitleTableDefinition
        {
            entity.SetField("lineSpacing", value);
            return entity;
        }

        public static T SetWordSpacing<T>(this T entity, float value)
            where T : SubtitleTableDefinition
        {
            entity.SetField("wordSpacing", value);
            return entity;
        }
    }
}