using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetEntity))]
    public static class RulesetEntityExtensions
    {
        public static T SetDescriptionChanged<T>(this T entity, EntityDescription.DescriptionChangedHandler value)
            where T : RulesetEntity
        {
            entity.SetField("<DescriptionChanged>k__BackingField", value);
            return entity;
        }

        public static T SetEntityDescription<T>(this T entity, EntityDescription value)
            where T : RulesetEntity
        {
            entity.SetField("entityDescription", value);
            return entity;
        }

        public static T SetEntityImplementation<T>(this T entity, IEntityImplementation value)
            where T : RulesetEntity
        {
            entity.SetField("<EntityImplementation>k__BackingField", value);
            return entity;
        }

        public static T SetGuid<T>(this T entity, ulong value)
            where T : RulesetEntity
        {
            entity.SetField("guid", value);
            return entity;
        }
    }
}