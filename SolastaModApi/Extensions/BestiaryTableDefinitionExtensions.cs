using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class BestiaryTableDefinitionExtensions
    {
        public static T SetCellHeight<T>(this T entity, float value)
            where T : BestiaryTableDefinition
        {
            entity.SetField("cellHeight", value);
            return entity;
        }

        public static T SetCellWidth<T>(this T entity, float value)
            where T : BestiaryTableDefinition
        {
            entity.SetField("cellWidth", value);
            return entity;
        }
    }
}