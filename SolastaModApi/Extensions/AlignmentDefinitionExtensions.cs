using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(AlignmentDefinition))]
    public static class AlignmentDefinitionExtensions
    {
        public static T SetGoodnessAxis<T>(this T entity, int value)
            where T : AlignmentDefinition
        {
            entity.SetField("goodnessAxis", value);
            return entity;
        }

        public static T SetLawAxis<T>(this T entity, int value)
            where T : AlignmentDefinition
        {
            entity.SetField("lawAxis", value);
            return entity;
        }
    }
}