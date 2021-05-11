using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static AnimationDefinitions;
using static CursorDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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