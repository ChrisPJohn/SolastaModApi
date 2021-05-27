using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetEffectSpell))]
    public static class RulesetEffectSpellExtensions
    {
        public static T SetCaster<T>(this T entity, RulesetCharacter value)
            where T : RulesetEffectSpell
        {
            entity.SetField("caster", value);
            return entity;
        }

        public static T SetCasterId<T>(this T entity, ulong value)
            where T : RulesetEffectSpell
        {
            entity.SetField("casterId", value);
            return entity;
        }

        public static T SetIdentifiedBy<T>(this T entity, string value)
            where T : RulesetEffectSpell
        {
            entity.SetField("<IdentifiedBy>k__BackingField", value);
            return entity;
        }

        public static T SetOriginItem<T>(this T entity, RulesetItemDevice value)
            where T : RulesetEffectSpell
        {
            entity.SetField("originItem", value);
            return entity;
        }

        public static T SetSpellDefinition<T>(this T entity, SpellDefinition value)
            where T : RulesetEffectSpell
        {
            entity.SetField("spellDefinition", value);
            return entity;
        }

        public static T SetSpellRepertoire<T>(this T entity, RulesetSpellRepertoire value)
            where T : RulesetEffectSpell
        {
            entity.SetField("spellRepertoire", value);
            return entity;
        }
    }
}