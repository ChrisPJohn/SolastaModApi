using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionAttributeModifier))]
    public static class FeatureDefinitionAttributeModifierExtensions
    {
        public static T SetModifiedAttribute<T>(this T entity, string value)
            where T : FeatureDefinitionAttributeModifier
        {
            entity.SetField("modifiedAttribute", value);
            return entity;
        }

        public static T SetModifierType<T>(this T entity, FeatureDefinitionAttributeModifier.AttributeModifierOperationOld value)
            where T : FeatureDefinitionAttributeModifier
        {
            entity.SetField("modifierType", value);
            return entity;
        }

        public static T SetModifierType2<T>(this T entity, FeatureDefinitionAttributeModifier.AttributeModifierOperation value)
            where T : FeatureDefinitionAttributeModifier
        {
            entity.SetField("modifierType2", value);
            return entity;
        }

        public static T SetModifierValue<T>(this T entity, int value)
            where T : FeatureDefinitionAttributeModifier
        {
            entity.SetField("modifierValue", value);
            return entity;
        }

        public static T SetSituationalContext<T>(this T entity, SituationalContext value)
            where T : FeatureDefinitionAttributeModifier
        {
            entity.SetField("situationalContext", value);
            return entity;
        }
    }
}