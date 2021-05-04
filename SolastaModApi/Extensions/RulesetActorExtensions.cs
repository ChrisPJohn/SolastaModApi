using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class RulesetActorExtensions
    {
        public static T SetActionModifier<T>(this T entity, ActionModifier value)
            where T : RulesetActor
        {
            entity.SetField("actionModifier", value);
            return entity;
        }

        public static T SetPostLoaded<T>(this T entity, bool value)
            where T : RulesetActor
        {
            entity.SetField("<PostLoaded>k__BackingField", value);
            return entity;
        }

        public static T SetSide<T>(this T entity, Side value)
            where T : RulesetActor
        {
            entity.SetField("side", value);
            return entity;
        }
    }
}