using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EnvironmentDefinition))]
    public static class EnvironmentDefinitionExtensions
    {
        public static EnvironmentDefinition SetOutdoor(this EnvironmentDefinition entity, bool value)
        {
            entity.SetField("outdoor", value);
            return entity;
        }

        public static EnvironmentDefinition SetSceneReferenceOverride(this EnvironmentDefinition entity, AssetReference value)
        {
            entity.SetField("sceneReferenceOverride", value);
            return entity;
        }
    }
}