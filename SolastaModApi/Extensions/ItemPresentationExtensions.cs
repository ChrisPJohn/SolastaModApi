using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class ItemPresentationExtensions
    {
        public static T SetArmorAddressableName<T>(this T entity, string value)
            where T : ItemPresentation
        {
            entity.SetField("armorAddressableName", value);
            return entity;
        }

        public static T SetAssetReference<T>(this T entity, AssetReference value)
            where T : ItemPresentation
        {
            entity.SetField("assetReference", value);
            return entity;
        }

        public static T SetCrownVariationMask<T>(this T entity, int value)
            where T : ItemPresentation
        {
            entity.SetField("crownVariationMask", value);
            return entity;
        }

        public static T SetCustomArmorMaterial<T>(this T entity, string value)
            where T : ItemPresentation
        {
            entity.SetField("customArmorMaterial", value);
            return entity;
        }

        public static T SetFemaleBodyPartBehaviours<T>(this T entity, GraphicsCharacterDefinitions.BodyPartBehaviour[] value)
            where T : ItemPresentation
        {
            entity.SetField("femaleBodyPartBehaviours", value);
            return entity;
        }

        public static T SetHasCrownVariationMask<T>(this T entity, bool value)
            where T : ItemPresentation
        {
            entity.SetField("hasCrownVariationMask", value);
            return entity;
        }

        public static T SetMaleBodyPartBehaviours<T>(this T entity, GraphicsCharacterDefinitions.BodyPartBehaviour[] value)
            where T : ItemPresentation
        {
            entity.SetField("maleBodyPartBehaviours", value);
            return entity;
        }

        public static T SetOverrideSubtype<T>(this T entity, string value)
            where T : ItemPresentation
        {
            entity.SetField("overrideSubtype", value);
            return entity;
        }

        public static T SetSameBehavioursForMaleAndFemale<T>(this T entity, bool value)
            where T : ItemPresentation
        {
            entity.SetField("sameBehavioursForMaleAndFemale", value);
            return entity;
        }

        public static T SetUnidentifiedDescription<T>(this T entity, string value)
            where T : ItemPresentation
        {
            entity.SetField("unidentifiedDescription", value);
            return entity;
        }

        public static T SetUnidentifiedTitle<T>(this T entity, string value)
            where T : ItemPresentation
        {
            entity.SetField("unidentifiedTitle", value);
            return entity;
        }

        public static T SetUseArmorAddressableName<T>(this T entity, bool value)
            where T : ItemPresentation
        {
            entity.SetField("useArmorAddressableName", value);
            return entity;
        }

        public static T SetUseCustomArmorMaterial<T>(this T entity, bool value)
            where T : ItemPresentation
        {
            entity.SetField("useCustomArmorMaterial", value);
            return entity;
        }
    }
}