using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MerchantDefinition))]
    public static partial class MerchantDefinitionExtensions
    {
        public static T SetBuyBackPercent<T>(this T entity, int value)
            where T : MerchantDefinition
        {
            entity.BuyBackPercent = value;
            return entity;
        }

        public static T SetCanDetectMagic<T>(this T entity, bool value)
            where T : MerchantDefinition
        {
            entity.CanDetectMagic = value;
            return entity;
        }

        public static T SetCanIdentify<T>(this T entity, bool value)
            where T : MerchantDefinition
        {
            entity.CanIdentify = value;
            return entity;
        }

        public static T SetDetectMagicCostGp<T>(this T entity, int value)
            where T : MerchantDefinition
        {
            entity.DetectMagicCostGp = value;
            return entity;
        }

        public static T SetExposeFaction<T>(this T entity, bool value)
            where T : MerchantDefinition
        {
            entity.SetField("exposeFaction", value);
            return entity;
        }

        public static T SetFactionAffinity<T>(this T entity, string value)
            where T : MerchantDefinition
        {
            entity.SetField("factionAffinity", value);
            return entity;
        }

        public static T SetIdentifyCostGp<T>(this T entity, int value)
            where T : MerchantDefinition
        {
            entity.IdentifyCostGp = value;
            return entity;
        }

        public static T SetInDungeonEditor<T>(this T entity, bool value)
            where T : MerchantDefinition
        {
            entity.InDungeonEditor = value;
            return entity;
        }

        public static T SetOverchargePercent<T>(this T entity, int value)
            where T : MerchantDefinition
        {
            entity.OverchargePercent = value;
            return entity;
        }

        public static T SetUserMerchantInventory<T>(this T entity, bool value)
            where T : MerchantDefinition
        {
            entity.SetField("<UserMerchantInventory>k__BackingField", value);
            return entity;
        }
    }
}