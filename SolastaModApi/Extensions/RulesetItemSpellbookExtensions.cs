using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetItemSpellbook))]
    public static partial class RulesetItemSpellbookExtensions
    {
        public static T SetScribingId<T>(this T entity, int value)
            where T : RulesetItemSpellbook
        {
            entity.ScribingId = value;
            return entity;
        }
    }
}