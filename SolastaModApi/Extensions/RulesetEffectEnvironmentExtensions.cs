using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetEffectEnvironment))]
    public static partial class RulesetEffectEnvironmentExtensions
    {
        public static T SetAddDice<T>(this T entity, int value)
            where T : RulesetEffectEnvironment
        {
            entity.SetField("addDice", value);
            return entity;
        }

        public static T SetEnvironmentEffectDefinition<T>(this T entity, EnvironmentEffectDefinition value)
            where T : RulesetEffectEnvironment
        {
            entity.SetField("environmentEffectDefinition", value);
            return entity;
        }

        public static T SetSavingThrowDCOverride<T>(this T entity, int value)
            where T : RulesetEffectEnvironment
        {
            entity.SetField("savingThrowDCOverride", value);
            return entity;
        }
    }
}