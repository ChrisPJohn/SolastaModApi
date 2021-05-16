using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TutorialTocDefinition))]
    public static class TutorialTocDefinitionExtensions
    {
        public static T SetSectionLineHeight<T>(this T entity, float value)
            where T : TutorialTocDefinition
        {
            entity.SetField("sectionLineHeight", value);
            return entity;
        }

        public static T SetSubsectionHeaderHeight<T>(this T entity, float value)
            where T : TutorialTocDefinition
        {
            entity.SetField("subsectionHeaderHeight", value);
            return entity;
        }

        public static T SetSubsectionIndentWidth<T>(this T entity, float value)
            where T : TutorialTocDefinition
        {
            entity.SetField("subsectionIndentWidth", value);
            return entity;
        }

        public static T SetSubsectionLineHeight<T>(this T entity, float value)
            where T : TutorialTocDefinition
        {
            entity.SetField("subsectionLineHeight", value);
            return entity;
        }

        public static T SetSubsectionLineSpacing<T>(this T entity, float value)
            where T : TutorialTocDefinition
        {
            entity.SetField("subsectionLineSpacing", value);
            return entity;
        }

        public static T SetSubsectionTrailingHeight<T>(this T entity, float value)
            where T : TutorialTocDefinition
        {
            entity.SetField("subsectionTrailingHeight", value);
            return entity;
        }
    }
}