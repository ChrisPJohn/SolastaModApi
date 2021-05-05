using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TooltipFeatureSpellAdvancementExtensions
    {
        public static T SetAdvancementLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureSpellAdvancement
        {
            entity.SetField("advancementLabel", value);
            return entity;
        }
    }
}