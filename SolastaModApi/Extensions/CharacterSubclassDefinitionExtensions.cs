using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CharacterSubclassDefinition))]
    public static partial class CharacterSubclassDefinitionExtensions
    {
        public static T SetMorphotypeSubclassFilterTag<T>(this T entity, GraphicsDefinitions.MorphotypeSubclassFilterTag value)
            where T : CharacterSubclassDefinition
        {
            entity.SetField("morphotypeSubclassFilterTag", value);
            return entity;
        }
    }
}