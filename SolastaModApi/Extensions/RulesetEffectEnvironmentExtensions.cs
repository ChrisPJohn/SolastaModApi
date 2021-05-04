using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class RulesetEffectEnvironmentExtensions
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