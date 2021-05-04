using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class AnimationEventParametersExtensions
    {
        public static T SetAudioEvent<T>(this T entity, Event value)
            where T : AnimationEventParameters
        {
            entity.SetField("audioEvent", value);
            return entity;
        }

        public static T SetCharacterEvent<T>(this T entity, GameLocationCharacterEventSystem.Event value)
            where T : AnimationEventParameters
        {
            entity.SetField("characterEvent", value);
            return entity;
        }

        public static T SetDirtFootstepParticlePrefab<T>(this T entity, AssetReference value)
            where T : AnimationEventParameters
        {
            entity.SetField("dirtFootstepParticlePrefab", value);
            return entity;
        }

        public static T SetIgnoreBlendRestriction<T>(this T entity, bool value)
            where T : AnimationEventParameters
        {
            entity.SetField("ignoreBlendRestriction", value);
            return entity;
        }

        public static T SetMudFootstepParticlePrefab<T>(this T entity, AssetReference value)
            where T : AnimationEventParameters
        {
            entity.SetField("mudFootstepParticlePrefab", value);
            return entity;
        }

        public static T SetParticlePrefab<T>(this T entity, AssetReference value)
            where T : AnimationEventParameters
        {
            entity.SetField("particlePrefab", value);
            return entity;
        }

        public static T SetPreferredCharacterAudioNode<T>(this T entity, AudioCharacterNode.Type value)
            where T : AnimationEventParameters
        {
            entity.SetField("preferredCharacterAudioNode", value);
            return entity;
        }

        public static T SetPreferredGadgetAudioNode<T>(this T entity, AudioGadgetNode.Type value)
            where T : AnimationEventParameters
        {
            entity.SetField("preferredGadgetAudioNode", value);
            return entity;
        }

        public static T SetWaterThighFootstepParticlePrefab<T>(this T entity, AssetReference value)
            where T : AnimationEventParameters
        {
            entity.SetField("waterThighFootstepParticlePrefab", value);
            return entity;
        }
    }
}