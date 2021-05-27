using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(AmmunitionDescription))]
    public static class AmmunitionDescriptionExtensions
    {
        public static T SetAmmunitionType<T>(this T entity, string value)
            where T : AmmunitionDescription
        {
            entity.SetField("ammunitionType", value);
            return entity;
        }

        public static T SetApplyCharacterScale<T>(this T entity, bool value)
            where T : AmmunitionDescription
        {
            entity.SetField("applyCharacterScale", value);
            return entity;
        }

        public static T SetEffectDescription<T>(this T entity, EffectDescription value)
            where T : AmmunitionDescription
        {
            entity.SetField("effectDescription", value);
            return entity;
        }
    }
}