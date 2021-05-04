using SolastaModApi.Infrastructure;
using System.Text;
using static RuleDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionProficiencyExtensions
    {
        public static T SetProficienciesFormat<T>(this T entity, StringBuilder value)
            where T : FeatureDefinitionProficiency
        {
            entity.SetField("proficienciesFormat", value);
            return entity;
        }

        public static T SetProficiencyType<T>(this T entity, ProficiencyType value)
            where T : FeatureDefinitionProficiency
        {
            entity.SetField("proficiencyType", value);
            return entity;
        }
    }
}