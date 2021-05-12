using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EnvironmentDefinition))]
    public static class EnvironmentDefinitionExtensions
    {
        public static EnvironmentDefinition SetDimensions(this EnvironmentDefinition entity, Vector2Int value)
        {
            entity.SetField("dimensions", value);
            return entity;
        }

        public static EnvironmentDefinition SetHasFixedDimensions(this EnvironmentDefinition entity, bool value)
        {
            entity.SetField("hasFixedDimensions", value);
            return entity;
        }
    }
}