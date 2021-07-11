using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EditableGraphDefinition))]
    public static partial class EditableGraphDefinitionExtensions
    {
        public static T SetRootState<T>(this T entity, EditableStateDescription value)
            where T : EditableGraphDefinition
        {
            entity.RootState = value;
            return entity;
        }

        public static T SetRootStateIndex<T>(this T entity, int value)
            where T : EditableGraphDefinition
        {
            entity.RootStateIndex = value;
            return entity;
        }

        public static T SetStartPosition<T>(this T entity, Vector2 value)
            where T : EditableGraphDefinition
        {
            entity.StartPosition = value;
            return entity;
        }
    }
}