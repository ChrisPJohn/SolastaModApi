using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FightingStyleDefinitionExtensions
    {
        public static T SetCondition<T>(this T entity, FightingStyleDefinition.TriggerCondition value)
            where T : FightingStyleDefinition
        {
            entity.SetField("condition", value);
            return entity;
        }
    }
}