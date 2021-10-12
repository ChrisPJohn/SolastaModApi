using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CreditsTableDefinition))]
    public static partial class CreditsTableDefinitionExtensions
    {
        public static T SetBackersTextAsset<T>(this T entity, TextAsset value)
            where T : CreditsTableDefinition
        {
            entity.SetField("backersTextAsset", value);
            return entity;
        }

        public static T SetDescriptionLineHeight<T>(this T entity, float value)
            where T : CreditsTableDefinition
        {
            entity.SetField("descriptionLineHeight", value);
            return entity;
        }

        public static T SetDescriptionWordSpacing<T>(this T entity, float value)
            where T : CreditsTableDefinition
        {
            entity.SetField("descriptionWordSpacing", value);
            return entity;
        }

        public static T SetJobTitleLineHeight<T>(this T entity, float value)
            where T : CreditsTableDefinition
        {
            entity.SetField("jobTitleLineHeight", value);
            return entity;
        }

        public static T SetLargeSpacingHeight<T>(this T entity, float value)
            where T : CreditsTableDefinition
        {
            entity.SetField("largeSpacingHeight", value);
            return entity;
        }

        public static T SetNameLineHeight<T>(this T entity, float value)
            where T : CreditsTableDefinition
        {
            entity.SetField("nameLineHeight", value);
            return entity;
        }

        public static T SetSectionLineHeight<T>(this T entity, float value)
            where T : CreditsTableDefinition
        {
            entity.SetField("sectionLineHeight", value);
            return entity;
        }

        public static T SetSmallSpacingHeight<T>(this T entity, float value)
            where T : CreditsTableDefinition
        {
            entity.SetField("smallSpacingHeight", value);
            return entity;
        }
    }
}