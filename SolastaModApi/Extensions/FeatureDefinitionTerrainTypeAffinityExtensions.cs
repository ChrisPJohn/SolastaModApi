using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionTerrainTypeAffinityExtensions
    {
        public static T SetFoodYieldMultiplier<T>(this T entity, float value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            entity.SetField("foodYieldMultiplier", value);
            return entity;
        }

        public static T SetIgnoreTravelPacePerceptionMalus<T>(this T entity, bool value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            entity.SetField("ignoreTravelPacePerceptionMalus", value);
            return entity;
        }

        public static T SetIngredientYieldMultiplier<T>(this T entity, float value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            entity.SetField("ingredientYieldMultiplier", value);
            return entity;
        }

        public static T SetTerrainType<T>(this T entity, string value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            entity.SetField("terrainType", value);
            return entity;
        }

        public static T SetTravelSpeedMultiplier<T>(this T entity, float value)
            where T : FeatureDefinitionTerrainTypeAffinity
        {
            entity.SetField("travelSpeedMultiplier", value);
            return entity;
        }
    }
}