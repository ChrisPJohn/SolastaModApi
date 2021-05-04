using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class RulesetConditionExtensions
    {
        public static T SetDurationType<T>(this T entity, DurationType value)
            where T : RulesetCondition
        {
            entity.SetField("durationType", value);
            return entity;
        }
    }
}