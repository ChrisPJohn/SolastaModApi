using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FactionRelicDescriptionExtensions
    {
        public static T SetLoreValue<T>(this T entity, int value)
            where T : FactionRelicDescription
        {
            entity.SetField("loreValue", value);
            return entity;
        }

        public static T SetRedeemCosts<T>(this T entity, int[] value)
            where T : FactionRelicDescription
        {
            entity.SetField("redeemCosts", value);
            return entity;
        }
    }
}