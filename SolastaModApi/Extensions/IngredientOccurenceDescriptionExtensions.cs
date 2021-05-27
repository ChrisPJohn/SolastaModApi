using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(IngredientOccurenceDescription))]
    public static class IngredientOccurenceDescriptionExtensions
    {
        public static T SetAmount<T>(this T entity, int value)
            where T : IngredientOccurenceDescription
        {
            entity.SetField("amount", value);
            return entity;
        }

        public static T SetItemDefinition<T>(this T entity, ItemDefinition value)
            where T : IngredientOccurenceDescription
        {
            entity.SetField("itemDefinition", value);
            return entity;
        }
    }
}