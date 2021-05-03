using SolastaModApi.Infrastructure;
using AK.Wwise;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class SoundEffectDescriptionExtensions
    {
        public static T SetGuiPickBody<T>(this T entity, Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("guiPickBody", value);
            return entity;
        }

        public static T SetGuiPickOther<T>(this T entity, Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("guiPickOther", value);
            return entity;
        }

        public static T SetGuiStoreBody<T>(this T entity, Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("guiStoreBody", value);
            return entity;
        }

        public static T SetGuiStoreOther<T>(this T entity, Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("guiStoreOther", value);
            return entity;
        }

        public static T SetStartEvent<T>(this T entity, Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("startEvent", value);
            return entity;
        }

        public static T SetStartSwitch<T>(this T entity, Switch value)
            where T : SoundEffectDescription
        {
            entity.SetField("startSwitch", value);
            return entity;
        }

        public static T SetStopEvent<T>(this T entity, Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("stopEvent", value);
            return entity;
        }

        public static T SetStopSwitch<T>(this T entity, Switch value)
            where T : SoundEffectDescription
        {
            entity.SetField("stopSwitch", value);
            return entity;
        }
    }
}