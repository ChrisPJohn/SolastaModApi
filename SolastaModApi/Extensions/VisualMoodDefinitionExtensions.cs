using SolastaModApi.Infrastructure;
using UnityEngine.Rendering.PostProcessing;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class VisualMoodDefinitionExtensions
    {
        public static VisualMoodDefinition SetGlobalPostProcessProfile(this VisualMoodDefinition entity, PostProcessProfile value)
        {
            entity.SetField("globalPostProcessProfile", value);
            return entity;
        }

        public static VisualMoodDefinition SetRenderSettingsSceneProfile(this VisualMoodDefinition entity, RenderSettingsSceneProfile value)
        {
            entity.SetField("renderSettingsSceneProfile", value);
            return entity;
        }
    }
}