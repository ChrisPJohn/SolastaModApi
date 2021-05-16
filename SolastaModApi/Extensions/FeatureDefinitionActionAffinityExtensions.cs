using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionActionAffinity))]
    public static class FeatureDefinitionActionAffinityExtensions
    {
        public static T SetEitherMainOrBonus<T>(this T entity, bool value)
            where T : FeatureDefinitionActionAffinity
        {
            entity.SetField("eitherMainOrBonus", value);
            return entity;
        }

        public static T SetMaxAttacksNumber<T>(this T entity, int value)
            where T : FeatureDefinitionActionAffinity
        {
            entity.SetField("maxAttacksNumber", value);
            return entity;
        }

        public static T SetRandomBehaviorDie<T>(this T entity, DieType value)
            where T : FeatureDefinitionActionAffinity
        {
            entity.SetField("randomBehaviorDie", value);
            return entity;
        }

        public static T SetSpecialBehaviour<T>(this T entity, SpecialBehaviour value)
            where T : FeatureDefinitionActionAffinity
        {
            entity.SetField("specialBehaviour", value);
            return entity;
        }
    }
}