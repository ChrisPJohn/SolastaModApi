using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ItemPropertyForm))]
    public static class ItemPropertyFormExtensions
    {
        public static T SetUsageLimitation<T>(this T entity, ItemPropertyUsage value)
            where T : ItemPropertyForm
        {
            entity.SetField("usageLimitation", value);
            return entity;
        }

        public static T SetUseAmount<T>(this T entity, int value)
            where T : ItemPropertyForm
        {
            entity.SetField("useAmount", value);
            return entity;
        }
    }
}