using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;
using static CursorDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CharacterInteractionDefinition))]
    public static class CharacterInteractionDefinitionExtensions
    {
        public static T SetActionId<T>(this T entity, Id value)
            where T : CharacterInteractionDefinition
        {
            entity.SetField("actionId", value);
            return entity;
        }

        public static T SetAnimation<T>(this T entity, ManipulationType value)
            where T : CharacterInteractionDefinition
        {
            entity.SetField("animation", value);
            return entity;
        }

        public static T SetCursorType<T>(this T entity, CursorType value)
            where T : CharacterInteractionDefinition
        {
            entity.SetField("cursorType", value);
            return entity;
        }
    }
}