using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FactionStatusDefinition))]
    public static class FactionStatusDefinitionExtensions
    {
        public static T SetCeiling<T>(this T entity, int value)
            where T : FactionStatusDefinition
        {
            entity.SetField("ceiling", value);
            return entity;
        }

        public static T SetCombatSide<T>(this T entity, Side value)
            where T : FactionStatusDefinition
        {
            entity.SetField("combatSide", value);
            return entity;
        }

        public static T SetExplorationSide<T>(this T entity, Side value)
            where T : FactionStatusDefinition
        {
            entity.SetField("explorationSide", value);
            return entity;
        }

        public static T SetMerchantRebatePercent<T>(this T entity, int value)
            where T : FactionStatusDefinition
        {
            entity.SetField("merchantRebatePercent", value);
            return entity;
        }
    }
}