using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(StockUnitDescription))]
    public static partial class StockUnitDescriptionExtensions
    {
        public static T SetFactionStatus<T>(this T entity, string value)
            where T : StockUnitDescription
        {
            entity.SetField("factionStatus", value);
            return entity;
        }

        public static T SetInitialAmount<T>(this T entity, int value)
            where T : StockUnitDescription
        {
            entity.InitialAmount = value;
            return entity;
        }

        public static T SetInitialized<T>(this T entity, bool value)
            where T : StockUnitDescription
        {
            entity.SetField("initialized", value);
            return entity;
        }

        public static T SetItemDefinition<T>(this T entity, ItemDefinition value)
            where T : StockUnitDescription
        {
            entity.ItemDefinition = value;
            return entity;
        }

        public static T SetMaxAmount<T>(this T entity, int value)
            where T : StockUnitDescription
        {
            entity.MaxAmount = value;
            return entity;
        }

        public static T SetMinAmount<T>(this T entity, int value)
            where T : StockUnitDescription
        {
            entity.MinAmount = value;
            return entity;
        }

        public static T SetReassortAmount<T>(this T entity, int value)
            where T : StockUnitDescription
        {
            entity.ReassortAmount = value;
            return entity;
        }

        public static T SetReassortRateType<T>(this T entity, DurationType value)
            where T : StockUnitDescription
        {
            entity.ReassortRateType = value;
            return entity;
        }

        public static T SetReassortRateValue<T>(this T entity, int value)
            where T : StockUnitDescription
        {
            entity.ReassortRateValue = value;
            return entity;
        }

        public static T SetRequiredFaction<T>(this T entity, string value)
            where T : StockUnitDescription
        {
            entity.RequiredFaction = value;
            return entity;
        }

        public static T SetStackCount<T>(this T entity, int value)
            where T : StockUnitDescription
        {
            entity.StackCount = value;
            return entity;
        }
    }
}