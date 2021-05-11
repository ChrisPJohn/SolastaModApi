using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FurnitureBlueprint))]
    public static class FurnitureBlueprintExtensions
    {
        public static T SetGroundPlacement<T>(this T entity, bool value)
            where T : FurnitureBlueprint
        {
            entity.SetField("groundPlacement", value);
            return entity;
        }

        public static T SetOpeningPlacement<T>(this T entity, bool value)
            where T : FurnitureBlueprint
        {
            entity.SetField("openingPlacement", value);
            return entity;
        }

        public static T SetPropPlacement<T>(this T entity, bool value)
            where T : FurnitureBlueprint
        {
            entity.SetField("propPlacement", value);
            return entity;
        }

        public static T SetWallPlacement<T>(this T entity, bool value)
            where T : FurnitureBlueprint
        {
            entity.SetField("wallPlacement", value);
            return entity;
        }
    }
}