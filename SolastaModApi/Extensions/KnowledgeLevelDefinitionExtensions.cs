using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class KnowledgeLevelDefinitionExtensions
    {
        public static T SetAccessFlags<T>(this T entity, int value)
            where T : KnowledgeLevelDefinition
        {
            entity.SetField("accessFlags", value);
            return entity;
        }

        public static T SetAdditionalDamage<T>(this T entity, int value)
            where T : KnowledgeLevelDefinition
        {
            entity.SetField("additionalDamage", value);
            return entity;
        }

        public static T SetLevel<T>(this T entity, int value)
            where T : KnowledgeLevelDefinition
        {
            entity.SetField("level", value);
            return entity;
        }
    }
}