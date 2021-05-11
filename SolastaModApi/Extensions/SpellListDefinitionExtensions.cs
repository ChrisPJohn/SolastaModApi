using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class SpellListDefinitionExtensions
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