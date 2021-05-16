using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(StageDefinition))]
    public static class StageDefinitionExtensions
    {
        public static T SetAddAudioCharacter<T>(this T entity, bool value)
            where T : StageDefinition
        {
            entity.SetField("addAudioCharacter", value);
            return entity;
        }

        public static T SetGraphicsCharacterType<T>(this T entity, GraphicsCharacterDefinitions.CharacterType value)
            where T : StageDefinition
        {
            entity.SetField("graphicsCharacterType", value);
            return entity;
        }

        public static T SetViewport<T>(this T entity, StageDefinition.ViewportMode value)
            where T : StageDefinition
        {
            entity.SetField("viewport", value);
            return entity;
        }
    }
}