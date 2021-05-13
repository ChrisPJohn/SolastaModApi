using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetEffectPower))]
    public static class RulesetEffectPowerExtensions
    {
        public static T SetOriginItem<T>(this T entity, RulesetItemDevice value)
            where T : RulesetEffectPower
        {
            entity.SetField("originItem", value);
            return entity;
        }

        public static T SetSourceDefinition<T>(this T entity, FeatureDefinitionPower value)
            where T : RulesetEffectPower
        {
            entity.SetField("sourceDefinition", value);
            return entity;
        }

        public static T SetUsableDeviceFunction<T>(this T entity, RulesetDeviceFunction value)
            where T : RulesetEffectPower
        {
            entity.SetField("usableDeviceFunction", value);
            return entity;
        }

        public static T SetUsablePower<T>(this T entity, RulesetUsablePower value)
            where T : RulesetEffectPower
        {
            entity.SetField("usablePower", value);
            return entity;
        }

        public static T SetUser<T>(this T entity, RulesetCharacter value)
            where T : RulesetEffectPower
        {
            entity.SetField("user", value);
            return entity;
        }

        public static T SetUserId<T>(this T entity, ulong value)
            where T : RulesetEffectPower
        {
            entity.SetField("userId", value);
            return entity;
        }
    }
}