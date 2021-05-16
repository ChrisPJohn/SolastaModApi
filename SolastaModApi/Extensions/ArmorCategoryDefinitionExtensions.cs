using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ArmorCategoryDefinition))]
    public static class ArmorCategoryDefinitionExtensions
    {
        public static T SetForbidsNegativeDexterityBonus<T>(this T entity, bool value)
            where T : ArmorCategoryDefinition
        {
            entity.SetField("forbidsNegativeDexterityBonus", value);
            return entity;
        }

        public static T SetIsPhysicalArmor<T>(this T entity, bool value)
            where T : ArmorCategoryDefinition
        {
            entity.SetField("isPhysicalArmor", value);
            return entity;
        }

        public static T SetNoiseRangeIfNotStealthProficient<T>(this T entity, int value)
            where T : ArmorCategoryDefinition
        {
            entity.SetField("noiseRangeIfNotStealthProficient", value);
            return entity;
        }

        public static T SetNoiseRangeIfStealthProficient<T>(this T entity, int value)
            where T : ArmorCategoryDefinition
        {
            entity.SetField("noiseRangeIfStealthProficient", value);
            return entity;
        }

        public static T SetRequiresProficiency<T>(this T entity, bool value)
            where T : ArmorCategoryDefinition
        {
            entity.SetField("requiresProficiency", value);
            return entity;
        }
    }
}