using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetCondition))]
    public static class RulesetConditionExtensions
    {
        public static T SetDurationChanged<T>(this T entity, RulesetCondition.DurationChangedHandler value)
            where T : RulesetCondition
        {
            entity.SetField("<DurationChanged>k__BackingField", value);
            return entity;
        }

        public static T SetDurationParameter<T>(this T entity, int value)
            where T : RulesetCondition
        {
            entity.SetField("durationParameter", value);
            return entity;
        }

        public static T SetDurationType<T>(this T entity, DurationType value)
            where T : RulesetCondition
        {
            entity.SetField("durationType", value);
            return entity;
        }

        public static T SetEffectDefinitionName<T>(this T entity, string value)
            where T : RulesetCondition
        {
            entity.SetField("effectDefinitionName", value);
            return entity;
        }

        public static T SetEffectLevel<T>(this T entity, int value)
            where T : RulesetCondition
        {
            entity.SetField("effectLevel", value);
            return entity;
        }

        public static T SetSourceFactionName<T>(this T entity, string value)
            where T : RulesetCondition
        {
            entity.SetField("sourceFactionName", value);
            return entity;
        }

        public static T SetSourceGuid<T>(this T entity, ulong value)
            where T : RulesetCondition
        {
            entity.SetField("sourceGuid", value);
            return entity;
        }
    }
}