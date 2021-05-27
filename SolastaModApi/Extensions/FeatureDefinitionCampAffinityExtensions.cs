using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionCampAffinity))]
    public static class FeatureDefinitionCampAffinityExtensions
    {
        public static T SetAwakeWhenCampAttacked<T>(this T entity, bool value)
            where T : FeatureDefinitionCampAffinity
        {
            entity.SetField("awakeWhenCampAttacked", value);
            return entity;
        }

        public static T SetEncounterNoSurpriseInCamp<T>(this T entity, bool value)
            where T : FeatureDefinitionCampAffinity
        {
            entity.SetField("encounterNoSurpriseInCamp", value);
            return entity;
        }

        public static T SetEncounterRollModifier<T>(this T entity, int value)
            where T : FeatureDefinitionCampAffinity
        {
            entity.SetField("encounterRollModifier", value);
            return entity;
        }

        public static T SetSleepDurationOverride<T>(this T entity, int value)
            where T : FeatureDefinitionCampAffinity
        {
            entity.SetField("sleepDurationOverride", value);
            return entity;
        }
    }
}