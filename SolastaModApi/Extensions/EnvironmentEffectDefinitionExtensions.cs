using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EnvironmentEffectDefinition))]
    public static partial class EnvironmentEffectDefinitionExtensions
    {
        public static T SetEffectDescription<T>(this T entity, EffectDescription value)
            where T : EnvironmentEffectDefinition
        {
            entity.SetField("effectDescription", value);
            return entity;
        }

        public static T SetInDungeonEditor<T>(this T entity, bool value)
            where T : EnvironmentEffectDefinition
        {
            entity.SetField("inDungeonEditor", value);
            return entity;
        }
    }
}