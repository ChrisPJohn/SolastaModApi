using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ArmorTypeDefinition))]
    public static class ArmorTypeDefinitionExtensions
    {
        public static T SetArmorCategory<T>(this T entity, string value)
            where T : ArmorTypeDefinition
        {
            entity.SetField("armorCategory", value);
            return entity;
        }

        public static T SetRequiresProficiency<T>(this T entity, bool value)
            where T : ArmorTypeDefinition
        {
            entity.SetField("requiresProficiency", value);
            return entity;
        }

        public static T SetSoundEffectDescription<T>(this T entity, SoundEffectDescription value)
            where T : ArmorTypeDefinition
        {
            entity.SetField("soundEffectDescription", value);
            return entity;
        }
    }
}