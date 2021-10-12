using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiMerchantDefinition))]
    public static partial class GuiMerchantDefinitionExtensions
    {
        public static T SetMerchantDefinition<T>(this T entity, MerchantDefinition value)
            where T : GuiMerchantDefinition
        {
            entity.SetField("<MerchantDefinition>k__BackingField", value);
            return entity;
        }
    }
}