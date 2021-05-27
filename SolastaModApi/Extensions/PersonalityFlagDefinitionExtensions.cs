using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(PersonalityFlagDefinition))]
    public static class PersonalityFlagDefinitionExtensions
    {
        public static T SetAlignmentFlag<T>(this T entity, bool value)
            where T : PersonalityFlagDefinition
        {
            entity.SetField("alignmentFlag", value);
            return entity;
        }

        public static T SetAnchor<T>(this T entity, Vector2 value)
            where T : PersonalityFlagDefinition
        {
            entity.SetField("anchor", value);
            return entity;
        }

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