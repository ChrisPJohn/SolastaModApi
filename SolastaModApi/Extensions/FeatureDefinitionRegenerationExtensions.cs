using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionRegeneration))]
    public static class FeatureDefinitionRegenerationExtensions
    {
        public static T SetBonus<T>(this T entity, int value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("bonus", value);
            return entity;
        }

        public static T SetDiceNumber<T>(this T entity, int value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("diceNumber", value);
            return entity;
        }

        public static T SetDieType<T>(this T entity, DieType value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("dieType", value);
            return entity;
        }

        public static T SetTickNumber<T>(this T entity, int value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("tickNumber", value);
            return entity;
        }

        public static T SetTickType<T>(this T entity, DurationType value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("tickType", value);
            return entity;
        }
    }
}