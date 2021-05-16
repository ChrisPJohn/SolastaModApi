using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(WealthPileDescription))]
    public static class WealthPileDescriptionExtensions
    {
        public static T SetBonuses<T>(this T entity, int[] value)
            where T : WealthPileDescription
        {
            entity.SetField("bonuses", value);
            return entity;
        }

        public static T SetDiceTypes<T>(this T entity, DieType[] value)
            where T : WealthPileDescription
        {
            entity.SetField("diceTypes", value);
            return entity;
        }

        public static T SetWealth<T>(this T entity, int[] value)
            where T : WealthPileDescription
        {
            entity.SetField("wealth", value);
            return entity;
        }
    }
}