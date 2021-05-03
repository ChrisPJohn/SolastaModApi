using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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