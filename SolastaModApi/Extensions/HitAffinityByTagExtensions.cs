using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(HitAffinityByTag))]
    public static class HitAffinityByTagExtensions
    {
        public static T SetAdvantageType<T>(this T entity, AdvantageType value)
            where T : HitAffinityByTag
        {
            entity.SetField("advantageType", value);
            return entity;
        }

        public static T SetTag<T>(this T entity, string value)
            where T : HitAffinityByTag
        {
            entity.SetField("tag", value);
            return entity;
        }
    }
}