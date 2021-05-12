using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FocusItemDescription))]
    public static class FocusItemDescriptionExtensions
    {
        public static T SetFocusType<T>(this T entity, EquipmentDefinitions.FocusType value)
            where T : FocusItemDescription
        {
            entity.SetField("focusType", value);
            return entity;
        }

        public static T SetShownAsFocus<T>(this T entity, bool value)
            where T : FocusItemDescription
        {
            entity.SetField("shownAsFocus", value);
            return entity;
        }
    }
}