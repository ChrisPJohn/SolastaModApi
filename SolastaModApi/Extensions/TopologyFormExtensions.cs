using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TopologyForm))]
    public static partial class TopologyFormExtensions
    {
        public static T SetChangeType<T>(this T entity, TopologyForm.Type value)
            where T : TopologyForm
        {
            entity.SetField("changeType", value);
            return entity;
        }

        public static T SetImpactsFlyingCharacters<T>(this T entity, bool value)
            where T : TopologyForm
        {
            entity.SetField("impactsFlyingCharacters", value);
            return entity;
        }
    }
}