using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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