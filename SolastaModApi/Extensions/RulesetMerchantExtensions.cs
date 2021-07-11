using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetMerchant))]
    public static partial class RulesetMerchantExtensions
    {
        public static T SetMerchantDefinition<T>(this T entity, MerchantDefinition value)
            where T : RulesetMerchant
        {
            entity.SetField("merchantDefinition", value);
            return entity;
        }

        public static T SetName<T>(this T entity, string value)
            where T : RulesetMerchant
        {
            entity.Name = value;
            return entity;
        }
    }
}