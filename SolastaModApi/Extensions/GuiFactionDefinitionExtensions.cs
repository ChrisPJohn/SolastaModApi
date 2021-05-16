using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiFactionDefinition))]
    public static class GuiFactionDefinitionExtensions
    {
        public static T SetFactionDefinition<T>(this T entity, FactionDefinition value)
            where T : GuiFactionDefinition
        {
            entity.SetField("<FactionDefinition>k__BackingField", value);
            return entity;
        }
    }
}