using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionDeathSavingThrowAffinityExtensions
    {
        public static T SetAdvantageType<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionDeathSavingThrowAffinity
        {
            entity.SetField("advantageType", value);
            return entity;
        }

        public static T SetRegainHitDieOnStabilize<T>(this T entity, bool value)
            where T : FeatureDefinitionDeathSavingThrowAffinity
        {
            entity.SetField("regainHitDieOnStabilize", value);
            return entity;
        }
    }
}