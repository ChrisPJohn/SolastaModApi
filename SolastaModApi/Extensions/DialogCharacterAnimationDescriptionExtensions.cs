using SolastaModApi.Infrastructure;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DialogCharacterAnimationDescription))]
    public static partial class DialogCharacterAnimationDescriptionExtensions
    {
        public static T SetAdditionalOffset<T>(this T entity, float value)
            where T : DialogCharacterAnimationDescription
        {
            entity.AdditionalOffset = value;
            return entity;
        }

        public static T SetBodyAnimationType<T>(this T entity, SpeakType value)
            where T : DialogCharacterAnimationDescription
        {
            entity.BodyAnimationType = value;
            return entity;
        }

        public static T SetBodyAnimationVariation<T>(this T entity, int value)
            where T : DialogCharacterAnimationDescription
        {
            entity.BodyAnimationVariation = value;
            return entity;
        }

        public static T SetCutAnimation<T>(this T entity, bool value)
            where T : DialogCharacterAnimationDescription
        {
            entity.CutAnimation = value;
            return entity;
        }

        public static T SetFacialExpression<T>(this T entity, FacialExpression value)
            where T : DialogCharacterAnimationDescription
        {
            entity.FacialExpression = value;
            return entity;
        }

        public static T SetLookAtTarget<T>(this T entity, string value)
            where T : DialogCharacterAnimationDescription
        {
            entity.LookAtTarget = value;
            return entity;
        }

        public static T SetLookAtType<T>(this T entity, NarrativeDefinitions.LookAtType value)
            where T : DialogCharacterAnimationDescription
        {
            entity.LookAtType = value;
            return entity;
        }

        public static T SetLoopAnimation<T>(this T entity, bool value)
            where T : DialogCharacterAnimationDescription
        {
            entity.LoopAnimation = value;
            return entity;
        }

        public static T SetOverrideLookAt<T>(this T entity, bool value)
            where T : DialogCharacterAnimationDescription
        {
            entity.OverrideLookAt = value;
            return entity;
        }

        public static T SetRole<T>(this T entity, string value)
            where T : DialogCharacterAnimationDescription
        {
            entity.Role = value;
            return entity;
        }
    }
}