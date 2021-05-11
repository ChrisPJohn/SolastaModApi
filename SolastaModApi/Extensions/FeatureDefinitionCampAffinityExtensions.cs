using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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