using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FoodDescription))]
    public static partial class FoodDescriptionExtensions
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