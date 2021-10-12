using SolastaModApi.Infrastructure;
using System.Linq;

namespace SolastaModApi.Extensions
{
    /*
    Allows code like

    Paladin
        .RemoveFeatureUnlock(PowerPaladinAuraOfCourage)
        .RemoveFeatureUnlock(PowerPaladinAuraOfProtection);

    Paladin
        .AddFeatureUnlock(PowerPaladinAuraOfCourage, 1)
        .AddFeatureUnlock(PowerPaladinAuraOfProtection, 1);
    */

    public static partial class CharacterClassDefinitionExtensions
    {
        public static T RemoveFeatureUnlock<T>(this T entity, FeatureDefinition feature) where T : CharacterClassDefinition
        {
            var fd = entity.FeatureUnlocks.Where(f => f.FeatureDefinition == feature).SingleOrDefault();

            if (fd != null)
            {
                entity.FeatureUnlocks.Remove(fd);
            }

            return entity;
        }

        public static T AddFeatureUnlock<T>(this T entity, FeatureDefinition feature, int level) where T : CharacterClassDefinition
        {
            entity.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));

            return entity;
        }

        public static T SortFeatureUnlocks<T>(this T entity) where T : CharacterClassDefinition
        {
            entity.FeatureUnlocks.SetRange(
                entity.FeatureUnlocks.OrderBy(fu => fu.Level).ThenBy(fu => fu.FeatureDefinition.Name));

            return entity;
        }
    }
}
