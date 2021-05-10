using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TooltipFeatureBaseMagicParametersExtensions
    {
        public static T SetRangeHeader<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureBaseMagicParameters
        {
            entity.SetField("rangeHeader", value);
            return entity;
        }

        public static T SetRangeLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureBaseMagicParameters
        {
            entity.SetField("rangeLabel", value);
            return entity;
        }

        public static T SetTargetLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureBaseMagicParameters
        {
            entity.SetField("targetLabel", value);
            return entity;
        }
    }
}