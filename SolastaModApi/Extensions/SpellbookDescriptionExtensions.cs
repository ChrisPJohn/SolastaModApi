using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SpellbookDescription))]
    public static class SpellbookDescriptionExtensions
    {
        public static T SetPagesCapacity<T>(this T entity, int value)
            where T : SpellbookDescription
        {
            entity.SetField("pagesCapacity", value);
            return entity;
        }
    }
}