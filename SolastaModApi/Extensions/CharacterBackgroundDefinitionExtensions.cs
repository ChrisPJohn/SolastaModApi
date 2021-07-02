using SolastaModApi.Infrastructure;
using static RuleDefinitions;
using static BanterDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CharacterBackgroundDefinition))]
    public static partial class CharacterBackgroundDefinitionExtensions
    {
        public static T SetBanterList<T>(this T entity, BanterList value)
            where T : CharacterBackgroundDefinition
        {
            entity.SetField("banterList", value);
            return entity;
        }

        public static T SetHasSubtype<T>(this T entity, bool value)
            where T : CharacterBackgroundDefinition
        {
            entity.SetField("hasSubtype", value);
            return entity;
        }

        public static T SetRequiresDeity<T>(this T entity, bool value)
            where T : CharacterBackgroundDefinition
        {
            entity.SetField("requiresDeity", value);
            return entity;
        }

        public static T SetSubTypeName<T>(this T entity, string value)
            where T : CharacterBackgroundDefinition
        {
            entity.SetField("subTypeName", value);
            return entity;
        }
    }
}