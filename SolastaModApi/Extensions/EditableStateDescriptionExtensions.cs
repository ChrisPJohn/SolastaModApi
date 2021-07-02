using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EditableStateDescription))]
    public static partial class EditableStateDescriptionExtensions
    {
        public static T SetIndex<T>(this T entity, int value)
            where T : EditableStateDescription
        {
            entity.SetField("<Index>k__BackingField", value);
            return entity;
        }
    }
}