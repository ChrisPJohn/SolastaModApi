using SolastaModApi.Infrastructure;
using UnityEngine;
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
        public static T SetChildrenStates<T>(this T entity, EditableStateDescription[] value)
            where T : EditableStateDescription
        {
            entity.ChildrenStates = value;
            return entity;
        }

        public static T SetChildrenStatesIndexes<T>(this T entity, int[] value)
            where T : EditableStateDescription
        {
            entity.ChildrenStatesIndexes = value;
            return entity;
        }

        public static T SetEditionColor<T>(this T entity, Color value)
            where T : EditableStateDescription
        {
            entity.EditionColor = value;
            return entity;
        }

        public static T SetEditionPosition<T>(this T entity, Vector2 value)
            where T : EditableStateDescription
        {
            entity.EditionPosition = value;
            return entity;
        }

        public static T SetIndex<T>(this T entity, int value)
            where T : EditableStateDescription
        {
            entity.SetField("<Index>k__BackingField", value);
            return entity;
        }
    }
}