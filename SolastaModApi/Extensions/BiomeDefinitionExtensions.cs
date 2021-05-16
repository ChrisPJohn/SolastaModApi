using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(BiomeDefinition))]
    public static class BiomeDefinitionExtensions
    {
        public static T SetEncounterTable<T>(this T entity, EncounterTableDefinition value)
            where T : BiomeDefinition
        {
            entity.SetField("encounterTable", value);
            return entity;
        }

        public static T SetTerrainType<T>(this T entity, string value)
            where T : BiomeDefinition
        {
            entity.SetField("terrainType", value);
            return entity;
        }
    }
}