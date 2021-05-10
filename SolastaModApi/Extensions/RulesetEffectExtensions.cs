using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class RulesetEffectExtensions
    {
        public static T SetActivationInProgress<T>(this T entity, bool value)
            where T : RulesetEffect
        {
            entity.SetField("<ActivationInProgress>k__BackingField", value);
            return entity;
        }

        public static T SetConditionTrackingStarted<T>(this T entity, RulesetEffect.ConditionTrackingStartedHandler value)
            where T : RulesetEffect
        {
            entity.SetField("<ConditionTrackingStarted>k__BackingField", value);
            return entity;
        }

        public static T SetConditionTrackingStopped<T>(this T entity, RulesetEffect.ConditionTrackingStoppedHandler value)
            where T : RulesetEffect
        {
            entity.SetField("<ConditionTrackingStopped>k__BackingField", value);
            return entity;
        }

        public static T SetDelayEnvironmentRegistration<T>(this T entity, bool value)
            where T : RulesetEffect
        {
            entity.SetField("<DelayEnvironmentRegistration>k__BackingField", value);
            return entity;
        }

        public static T SetTerminatedSelf<T>(this T entity, RulesetEffect.TerminatedSelfHandler value)
            where T : RulesetEffect
        {
            entity.SetField("<TerminatedSelf>k__BackingField", value);
            return entity;
        }

        public static T SetUpdated<T>(this T entity, RulesetEffect.RulesetActiveEffectUpdatedHandler value)
            where T : RulesetEffect
        {
            entity.SetField("<Updated>k__BackingField", value);
            return entity;
        }
    }
}