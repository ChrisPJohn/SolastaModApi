using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ArmorDescription))]
    public static class ArmorDescriptionExtensions
    {
        public static T SetArmorClassValue<T>(this T entity, int value)
            where T : ArmorDescription
        {
            entity.SetField("armorClassValue", value);
            return entity;
        }

        public static T SetArmorType<T>(this T entity, string value)
            where T : ArmorDescription
        {
            entity.SetField("armorType", value);
            return entity;
        }

        public static T SetIsBaseArmorClass<T>(this T entity, bool value)
            where T : ArmorDescription
        {
            entity.SetField("isBaseArmorClass", value);
            return entity;
        }

        public static T SetMaxDexterityBonus<T>(this T entity, int value)
            where T : ArmorDescription
        {
            entity.SetField("maxDexterityBonus", value);
            return entity;
        }

        public static T SetMinimalStrength<T>(this T entity, int value)
            where T : ArmorDescription
        {
            entity.SetField("minimalStrength", value);
            return entity;
        }

        public static T SetRequiresMinimalStrength<T>(this T entity, bool value)
            where T : ArmorDescription
        {
            entity.SetField("requiresMinimalStrength", value);
            return entity;
        }
    }
}