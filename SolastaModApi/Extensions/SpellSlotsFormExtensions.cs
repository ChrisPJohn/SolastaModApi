using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SpellSlotsForm))]
    public static class SpellSlotsFormExtensions
    {
        public static T SetMaxSlotLevel<T>(this T entity, int value)
            where T : SpellSlotsForm
        {
            entity.SetField("maxSlotLevel", value);
            return entity;
        }

        public static T SetType<T>(this T entity, SpellSlotsForm.EffectType value)
            where T : SpellSlotsForm
        {
            entity.SetField("type", value);
            return entity;
        }
    }
}