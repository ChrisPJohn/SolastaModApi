using SolastaModApi.Infrastructure;
using UnityEngine.Rendering.PostProcessing;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(VisualMoodDefinition))]
    public static class VisualMoodDefinitionExtensions
    {
        public static VisualMoodDefinition SetGlobalPostProcessProfile(this VisualMoodDefinition entity, PostProcessProfile value)
        {
            entity.SetField("globalPostProcessProfile", value);
            return entity;
        }

        public static VisualMoodDefinition SetOutdoor(this VisualMoodDefinition entity, bool value)
        {
            entity.SetField("outdoor", value);
            return entity;
        }

        public static VisualMoodDefinition SetRenderSettingsSceneProfile(this VisualMoodDefinition entity, RenderSettingsSceneProfile value)
        {
            entity.SetField("renderSettingsSceneProfile", value);
            return entity;
        }
    }
}