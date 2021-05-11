using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ReviveForm))]
    public static class ReviveFormExtensions
    {
        public static T SetMaxSecondsSinceDeath<T>(this T entity, int value)
            where T : ReviveForm
        {
            entity.SetField("maxSecondsSinceDeath", value);
            return entity;
        }

        public static T SetReviveHitPoints<T>(this T entity, ReviveHitPoints value)
            where T : ReviveForm
        {
            entity.SetField("reviveHitPoints", value);
            return entity;
        }
    }
}