using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MetamagicOptionDefinition))]
    public static partial class MetamagicOptionDefinitionExtensions
    {
        public static T SetBoundFeature<T>(this T entity, FeatureDefinition value)
            where T : MetamagicOptionDefinition
        {
            entity.SetField("boundFeature", value);
            return entity;
        }

        public static T SetCostMethod<T>(this T entity, MetamagicCostMethod value)
            where T : MetamagicOptionDefinition
        {
            entity.SetField("costMethod", value);
            return entity;
        }

        public static T SetMetamagicType<T>(this T entity, MetamagicType value)
            where T : MetamagicOptionDefinition
        {
            entity.SetField("metamagicType", value);
            return entity;
        }

        public static T SetParameterMethod<T>(this T entity, MetamagicParameterMethod value)
            where T : MetamagicOptionDefinition
        {
            entity.SetField("parameterMethod", value);
            return entity;
        }

        public static T SetParameterValue<T>(this T entity, int value)
            where T : MetamagicOptionDefinition
        {
            entity.SetField("parameterValue", value);
            return entity;
        }

        public static T SetSorceryPointsCost<T>(this T entity, int value)
            where T : MetamagicOptionDefinition
        {
            entity.SetField("sorceryPointsCost", value);
            return entity;
        }
    }
}