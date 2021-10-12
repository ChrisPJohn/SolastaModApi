using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ShapeOptionDescription))]
    public static partial class ShapeOptionDescriptionExtensions
    {
        public static T SetRequiredLevel<T>(this T entity, int value)
            where T : ShapeOptionDescription
        {
            entity.SetField("requiredLevel", value);
            return entity;
        }

        public static T SetSubstituteMonster<T>(this T entity, MonsterDefinition value)
            where T : ShapeOptionDescription
        {
            entity.SetField("substituteMonster", value);
            return entity;
        }
    }
}