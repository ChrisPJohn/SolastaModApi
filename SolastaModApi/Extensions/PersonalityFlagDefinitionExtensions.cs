using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(PersonalityFlagDefinition))]
    public static class PersonalityFlagDefinitionExtensions
    {
        public static T SetDialog<T>(this T entity, bool value)
            where T : PersonalityFlagDefinition
        {
            entity.SetField("dialog", value);
            return entity;
        }

        public static T SetGameplay<T>(this T entity, bool value)
            where T : PersonalityFlagDefinition
        {
            entity.SetField("gameplay", value);
            return entity;
        }
    }
}