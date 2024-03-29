using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiStockUnit))]
    public static class GuiStockUnitExtensions
    {
        public static T SetStockUnit<T>(this T entity, GameStockUnit value)
            where T : GuiStockUnit
        {
            entity.SetField("stockUnit", value);
            return entity;
        }
    }
}