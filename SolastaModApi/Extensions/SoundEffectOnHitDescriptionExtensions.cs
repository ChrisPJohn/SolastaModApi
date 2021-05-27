using SolastaModApi.Infrastructure;
using AK.Wwise;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SoundEffectOnHitDescription))]
    public static class SoundEffectOnHitDescriptionExtensions
    {
        public static T SetSwitchOnHit<T>(this T entity, Switch value)
            where T : SoundEffectOnHitDescription
        {
            entity.SetField("switchOnHit", value);
            return entity;
        }
    }
}