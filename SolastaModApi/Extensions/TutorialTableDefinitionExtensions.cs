using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TutorialTableDefinitionExtensions
    {
        public static T SetSectionLineHeight<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("sectionLineHeight", value);
            return entity;
        }

        public static T SetStepHeaderHeight<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("stepHeaderHeight", value);
            return entity;
        }

        public static T SetStepLineHeight<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("stepLineHeight", value);
            return entity;
        }

        public static T SetStepParagraphSpacing<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("stepParagraphSpacing", value);
            return entity;
        }

        public static T SetStepTitleHeight<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("stepTitleHeight", value);
            return entity;
        }

        public static T SetStepTralingHeight<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("stepTralingHeight", value);
            return entity;
        }

        public static T SetStepWordSpacing<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("stepWordSpacing", value);
            return entity;
        }

        public static T SetSubsectionIndentWidth<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("subsectionIndentWidth", value);
            return entity;
        }

        public static T SetSubsectionLineHeight<T>(this T entity, float value)
            where T : TutorialTableDefinition
        {
            entity.SetField("subsectionLineHeight", value);
            return entity;
        }
    }
}