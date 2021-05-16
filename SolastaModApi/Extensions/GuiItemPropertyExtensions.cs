using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiItemProperty))]
    public static class GuiItemPropertyExtensions
    {
        public static T SetItemProperty<T>(this T entity, RulesetItemProperty value)
            where T : GuiItemProperty
        {
            entity.SetField("itemProperty", value);
            return entity;
        }
    }
}