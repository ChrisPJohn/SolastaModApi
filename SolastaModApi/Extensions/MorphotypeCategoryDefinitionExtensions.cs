using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MorphotypeCategoryDefinition))]
    public static class MorphotypeCategoryDefinitionExtensions
    {
        public static T SetChoiceForm<T>(this T entity, MorphotypeCategoryDefinition.Form value)
            where T : MorphotypeCategoryDefinition
        {
            entity.SetField("choiceForm", value);
            return entity;
        }
    }
}