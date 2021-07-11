using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(VariableRegistrationDescription))]
    public static partial class VariableRegistrationDescriptionExtensions
    {
        public static T SetBoolValue<T>(this T entity, bool value)
            where T : VariableRegistrationDescription
        {
            entity.BoolValue = value;
            return entity;
        }

        public static T SetIntValue<T>(this T entity, int value)
            where T : VariableRegistrationDescription
        {
            entity.IntValue = value;
            return entity;
        }

        public static T SetName<T>(this T entity, string value)
            where T : VariableRegistrationDescription
        {
            entity.Name = value;
            return entity;
        }

        public static T SetStringValue<T>(this T entity, string value)
            where T : VariableRegistrationDescription
        {
            entity.StringValue = value;
            return entity;
        }

        public static T SetType<T>(this T entity, GameVariableDefinitions.Type value)
            where T : VariableRegistrationDescription
        {
            entity.Type = value;
            return entity;
        }
    }
}