using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FoodDescriptionExtensions
    {
        public static T SetNutritiveCapacity<T>(this T entity, int value)
            where T : FoodDescription
        {
            entity.SetField("nutritiveCapacity", value);
            return entity;
        }

        public static T SetPerishable<T>(this T entity, bool value)
            where T : FoodDescription
        {
            entity.SetField("perishable", value);
            return entity;
        }
    }
}