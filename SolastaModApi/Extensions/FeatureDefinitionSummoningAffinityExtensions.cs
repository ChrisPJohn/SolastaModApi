using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionSummoningAffinity))]
    public static partial class FeatureDefinitionSummoningAffinityExtensions
    {
        public static T SetEffectOnConjuredDeath<T>(this T entity, bool value)
            where T : FeatureDefinitionSummoningAffinity
        {
            entity.SetField("effectOnConjuredDeath", value);
            return entity;
        }

        public static T SetRequiredMonsterTag<T>(this T entity, string value)
            where T : FeatureDefinitionSummoningAffinity
        {
            entity.SetField("requiredMonsterTag", value);
            return entity;
        }
    }
}