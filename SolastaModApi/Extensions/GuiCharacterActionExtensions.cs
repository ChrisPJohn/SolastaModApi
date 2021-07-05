using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiCharacterAction))]
    public static partial class GuiCharacterActionExtensions
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

        public static T SetBaseDescription<T>(this T entity, string value)
            where T : GuiCharacterAction
        {
            entity.SetField("baseDescription", value);
            return entity;
        }

        public static T SetBaseTitle<T>(this T entity, string value)
            where T : GuiCharacterAction
        {
            entity.SetField("baseTitle", value);
            return entity;
        }

        public static T SetLastActionStatus<T>(this T entity, ActionStatus value)
            where T : GuiCharacterAction
        {
            entity.SetField("lastActionStatus", value);
            return entity;
        }

        public static T SetLastAttackMode<T>(this T entity, RulesetAttackMode value)
            where T : GuiCharacterAction
        {
            entity.SetField("lastAttackMode", value);
            return entity;
        }

        public static T SetLastEffectFormCount<T>(this T entity, int value)
            where T : GuiCharacterAction
        {
            entity.SetField("lastEffectFormCount", value);
            return entity;
        }

        public static T SetLastFailureString<T>(this T entity, string value)
            where T : GuiCharacterAction
        {
            entity.SetField("lastFailureString", value);
            return entity;
        }

        public static T SetLastTooltip<T>(this T entity, string value)
            where T : GuiCharacterAction
        {
            entity.SetField("lastTooltip", value);
            return entity;
        }
    }
}