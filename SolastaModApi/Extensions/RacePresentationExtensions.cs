using SolastaModApi.Infrastructure;
using UnityEngine;
using TA;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RacePresentation))]
    public static partial class RacePresentationExtensions
    {
        public static T SetBeardBlendShapes<T>(this T entity, RacePresentation.BeardBlendShape[] value)
            where T : RacePresentation
        {
            entity.SetField("beardBlendShapes", value);
            return entity;
        }

        public static T SetBodyAssetPrefix<T>(this T entity, string value)
            where T : RacePresentation
        {
            entity.SetField("bodyAssetPrefix", value);
            return entity;
        }

        public static T SetCanModifyMusculature<T>(this T entity, bool value)
            where T : RacePresentation
        {
            entity.SetField("canModifyMusculature", value);
            return entity;
        }

        public static T SetEquipmentLayoutPath<T>(this T entity, string value)
            where T : RacePresentation
        {
            entity.SetField("equipmentLayoutPath", value);
            return entity;
        }

        public static T SetFemaleVoiceDefinition<T>(this T entity, string value)
            where T : RacePresentation
        {
            entity.SetField("femaleVoiceDefinition", value);
            return entity;
        }

        public static T SetHasSurName<T>(this T entity, bool value)
            where T : RacePresentation
        {
            entity.SetField("hasSurName", value);
            return entity;
        }

        public static T SetMaleVoiceDefinition<T>(this T entity, string value)
            where T : RacePresentation
        {
            entity.SetField("maleVoiceDefinition", value);
            return entity;
        }

        public static T SetMorphotypeAssetPrefix<T>(this T entity, string value)
            where T : RacePresentation
        {
            entity.SetField("morphotypeAssetPrefix", value);
            return entity;
        }

        public static T SetNeedBeard<T>(this T entity, bool value)
            where T : RacePresentation
        {
            entity.SetField("needBeard", value);
            return entity;
        }

        public static T SetPortraitShieldOffset<T>(this T entity, Vector3 value)
            where T : RacePresentation
        {
            entity.SetField("portraitShieldOffset", value);
            return entity;
        }

        public static T SetPreferedHairColors<T>(this T entity, RangedInt value)
            where T : RacePresentation
        {
            entity.SetField("preferedHairColors", value);
            return entity;
        }

        public static T SetPreferedSkinColors<T>(this T entity, RangedInt value)
            where T : RacePresentation
        {
            entity.SetField("preferedSkinColors", value);
            return entity;
        }

        public static T SetSurNameTitle<T>(this T entity, string value)
            where T : RacePresentation
        {
            entity.SetField("surNameTitle", value);
            return entity;
        }

        public static T SetUseBeardBlendShape<T>(this T entity, bool value)
            where T : RacePresentation
        {
            entity.SetField("useBeardBlendShape", value);
            return entity;
        }
    }
}