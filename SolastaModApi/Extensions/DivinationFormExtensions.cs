using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DivinationForm))]
    public static class DivinationFormExtensions
    {
        public static T SetDivinationType<T>(this T entity, DivinationForm.Type value)
            where T : DivinationForm
        {
            entity.SetField("divinationType", value);
            return entity;
        }

        public static T SetRangeCells<T>(this T entity, int value)
            where T : DivinationForm
        {
            entity.SetField("rangeCells", value);
            return entity;
        }
    }
}