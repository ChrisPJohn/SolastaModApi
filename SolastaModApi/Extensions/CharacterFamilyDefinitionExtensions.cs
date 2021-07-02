using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CharacterFamilyDefinition))]
    public static partial class CharacterFamilyDefinitionExtensions
    {
        public static T SetExtraplanar<T>(this T entity, bool value)
            where T : CharacterFamilyDefinition
        {
            entity.SetField("extraplanar", value);
            return entity;
        }
    }
}