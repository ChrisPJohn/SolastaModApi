using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class ItemPropertyDescriptionExtensions
    {
        public static T SetAppliesOnItemOnly<T>(this T entity, bool value)
            where T : ItemPropertyDescription
        {
            entity.SetField("appliesOnItemOnly", value);
            return entity;
        }

        public static T SetConditionDefinition<T>(this T entity, ConditionDefinition value)
            where T : ItemPropertyDescription
        {
            entity.SetField("conditionDefinition", value);
            return entity;
        }

        public static T SetFeatureDefinition<T>(this T entity, FeatureDefinition value)
            where T : ItemPropertyDescription
        {
            entity.SetField("featureDefinition", value);
            return entity;
        }

        public static T SetKnowledgeAffinity<T>(this T entity, EquipmentDefinitions.KnowledgeAffinity value)
            where T : ItemPropertyDescription
        {
            entity.SetField("knowledgeAffinity", value);
            return entity;
        }

        public static T SetType<T>(this T entity, ItemPropertyDescription.PropertyType value)
            where T : ItemPropertyDescription
        {
            entity.SetField("type", value);
            return entity;
        }
    }
}