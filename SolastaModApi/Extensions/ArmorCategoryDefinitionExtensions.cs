using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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