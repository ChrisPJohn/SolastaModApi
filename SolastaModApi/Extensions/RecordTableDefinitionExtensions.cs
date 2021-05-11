using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RecordTableDefinition))]
    public static class RecordTableDefinitionExtensions
    {
        public static T SetAreaWidth<T>(this T entity, float value)
            where T : RecordTableDefinition
        {
            entity.SetField("areaWidth", value);
            return entity;
        }

        public static T SetLayout<T>(this T entity, RecordTableDefinition.LayoutType value)
            where T : RecordTableDefinition
        {
            entity.SetField("layout", value);
            return entity;
        }

        public static T SetMaxEntries<T>(this T entity, int value)
            where T : RecordTableDefinition
        {
            entity.SetField("maxEntries", value);
            return entity;
        }

        public static T SetMaxSerializedEntries<T>(this T entity, int value)
            where T : RecordTableDefinition
        {
            entity.SetField("maxSerializedEntries", value);
            return entity;
        }

        public static T SetOffsetX<T>(this T entity, float value)
            where T : RecordTableDefinition
        {
            entity.SetField("offsetX", value);
            return entity;
        }

        public static T SetOffsetY<T>(this T entity, float value)
            where T : RecordTableDefinition
        {
            entity.SetField("offsetY", value);
            return entity;
        }

        public static T SetSpacing<T>(this T entity, float value)
            where T : RecordTableDefinition
        {
            entity.SetField("spacing", value);
            return entity;
        }
    }
}