using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class CounterFormExtensions
    {
        public static T SetAddProficiencyBonus<T>(this T entity, bool value)
            where T : CounterForm
        {
            entity.SetField("addProficiencyBonus", value);
            return entity;
        }

        public static T SetAddSpellCastingAbility<T>(this T entity, bool value)
            where T : CounterForm
        {
            entity.SetField("addSpellCastingAbility", value);
            return entity;
        }

        public static T SetAutomaticSpellLevel<T>(this T entity, int value)
            where T : CounterForm
        {
            entity.SetField("automaticSpellLevel", value);
            return entity;
        }

        public static T SetCheckBaseDC<T>(this T entity, int value)
            where T : CounterForm
        {
            entity.SetField("checkBaseDC", value);
            return entity;
        }

        public static T SetType<T>(this T entity, CounterForm.CounterType value)
            where T : CounterForm
        {
            entity.SetField("type", value);
            return entity;
        }
    }
}