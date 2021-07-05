using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiFactionDefinition))]
    public static partial class GuiFactionDefinitionExtensions
    {
        public static T SetFactionDefinition<T>(this T entity, FactionDefinition value)
            where T : GuiFactionDefinition
        {
            entity.SetField("<FactionDefinition>k__BackingField", value);
            return entity;
        }
    }
}