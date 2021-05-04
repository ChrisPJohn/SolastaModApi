using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class MerchantDefinitionExtensions
    {
        public static T SetBuyBackPercent<T>(this T entity, int value)
            where T : MerchantDefinition
        {
            entity.SetField("buyBackPercent", value);
            return entity;
        }

        public static T SetCanDetectMagic<T>(this T entity, bool value)
            where T : MerchantDefinition
        {
            entity.SetField("canDetectMagic", value);
            return entity;
        }

        public static T SetCanIdentify<T>(this T entity, bool value)
            where T : MerchantDefinition
        {
            entity.SetField("canIdentify", value);
            return entity;
        }

        public static T SetDetectMagicCostGp<T>(this T entity, int value)
            where T : MerchantDefinition
        {
            entity.SetField("detectMagicCostGp", value);
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
            entity.SetField("identifyCostGp", value);
            return entity;
        }

        public static T SetOverchargePercent<T>(this T entity, int value)
            where T : MerchantDefinition
        {
            entity.SetField("overchargePercent", value);
            return entity;
        }
    }
}