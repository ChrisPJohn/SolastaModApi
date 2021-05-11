using SolastaModApi.Infrastructure;
using static ActionDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class GuiCharacterActionExtensions
    {
        public static T SetActingCharacter<T>(this T entity, GameLocationCharacter value)
            where T : GuiCharacterAction
        {
            entity.SetField("actingCharacter", value);
            return entity;
        }

        public static T SetActionDefinition<T>(this T entity, ActionDefinition value)
            where T : GuiCharacterAction
        {
            entity.SetField("actionDefinition", value);
            return entity;
        }

        public static T SetActionId<T>(this T entity, Id value)
            where T : GuiCharacterAction
        {
            entity.SetField("actionId", value);
            return entity;
        }

        public static T SetActionScope<T>(this T entity, ActionScope value)
            where T : GuiCharacterAction
        {
            entity.SetField("actionScope", value);
            return entity;
        }

        public static T SetActionTypeDefinition<T>(this T entity, ActionTypeDefinition value)
            where T : GuiCharacterAction
        {
            entity.SetField("actionTypeDefinition", value);
            return entity;
        }
    }
}