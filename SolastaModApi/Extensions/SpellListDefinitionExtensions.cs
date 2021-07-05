using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SpellListDefinition))]
    public static partial class SpellListDefinitionExtensions
    {
        public static T SetHasCantrips<T>(this T entity, bool value)
            where T : SpellListDefinition
        {
            entity.SetField("hasCantrips", value);
            return entity;
        }

        public static T SetMaxSpellLevel<T>(this T entity, int value)
            where T : SpellListDefinition
        {
            entity.SetField("maxSpellLevel", value);
            return entity;
        }
    }
}