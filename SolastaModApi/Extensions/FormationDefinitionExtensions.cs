using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FormationDefinition))]
    public static class FormationDefinitionExtensions
    {
        public static T SetDefaultFormation<T>(this T entity, bool value)
            where T : FormationDefinition
        {
            entity.SetField("defaultFormation", value);
            return entity;
        }
    }
}