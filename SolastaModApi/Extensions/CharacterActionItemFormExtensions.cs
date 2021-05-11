using SolastaModApi.Infrastructure;
using UnityEngine;
using UnityEngine.UI;
using static ActionDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class CharacterActionItemFormExtensions
    {
        public static T SetActionActivated<T>(this T entity, CharacterActionItemForm.ActionActivatedHandler value)
            where T : CharacterActionItemForm
        {
            entity.SetField("<ActionActivated>k__BackingField", value);
            return entity;
        }

        public static T SetAdditionalImages<T>(this T entity, Image[] value)
            where T : CharacterActionItemForm
        {
            entity.SetField("additionalImages", value);
            return entity;
        }

        public static T SetAdditionalImagesGrid<T>(this T entity, RectTransform value)
            where T : CharacterActionItemForm
        {
            entity.SetField("additionalImagesGrid", value);
            return entity;
        }

        public static T SetAttacksNumberGroup<T>(this T entity, RectTransform value)
            where T : CharacterActionItemForm
        {
            entity.SetField("attacksNumberGroup", value);
            return entity;
        }

        public static T SetAttacksNumberValue<T>(this T entity, GuiLabel value)
            where T : CharacterActionItemForm
        {
            entity.SetField("attacksNumberValue", value);
            return entity;
        }

        public static T SetBackground<T>(this T entity, Image value)
            where T : CharacterActionItemForm
        {
            entity.SetField("background", value);
            return entity;
        }

        public static T SetButton<T>(this T entity, Button value)
            where T : CharacterActionItemForm
        {
            entity.SetField("button", value);
            return entity;
        }

        public static T SetCanvasGroup<T>(this T entity, CanvasGroup value)
            where T : CharacterActionItemForm
        {
            entity.SetField("canvasGroup", value);
            return entity;
        }

        public static T SetCaptionLabel<T>(this T entity, GuiLabel value)
            where T : CharacterActionItemForm
        {
            entity.SetField("captionLabel", value);
            return entity;
        }

        public static T SetContentIcon<T>(this T entity, Image value)
            where T : CharacterActionItemForm
        {
            entity.SetField("contentIcon", value);
            return entity;
        }

        public static T SetContentLargeImage<T>(this T entity, Image value)
            where T : CharacterActionItemForm
        {
            entity.SetField("contentLargeImage", value);
            return entity;
        }

        public static T SetDarkColor<T>(this T entity, Color value)
            where T : CharacterActionItemForm
        {
            entity.SetField("darkColor", value);
            return entity;
        }

        public static T SetDarkDisabledColor<T>(this T entity, Color value)
            where T : CharacterActionItemForm
        {
            entity.SetField("darkDisabledColor", value);
            return entity;
        }

        public static T SetDynamicItemPropertiesEnumerator<T>(this T entity, DynamicItemPropertiesEnumerator value)
            where T : CharacterActionItemForm
        {
            entity.SetField("dynamicItemPropertiesEnumerator", value);
            return entity;
        }

        public static T SetFrame<T>(this T entity, Image value)
            where T : CharacterActionItemForm
        {
            entity.SetField("frame", value);
            return entity;
        }

        public static T SetGuiCharacterAction<T>(this T entity, GuiCharacterAction value)
            where T : CharacterActionItemForm
        {
            entity.SetField("guiCharacterAction", value);
            return entity;
        }

        public static T SetHighlightFrame<T>(this T entity, RectTransform value)
            where T : CharacterActionItemForm
        {
            entity.SetField("highlightFrame", value);
            return entity;
        }

        public static T SetHourGlass<T>(this T entity, RectTransform value)
            where T : CharacterActionItemForm
        {
            entity.SetField("hourGlass", value);
            return entity;
        }

        public static T SetHourGlassModifier<T>(this T entity, GuiModifierRotation value)
            where T : CharacterActionItemForm
        {
            entity.SetField("hourGlassModifier", value);
            return entity;
        }

        public static T SetHover<T>(this T entity, Image value)
            where T : CharacterActionItemForm
        {
            entity.SetField("hover", value);
            return entity;
        }

        public static T SetLimitedUseAmountLabel<T>(this T entity, GuiLabel value)
            where T : CharacterActionItemForm
        {
            entity.SetField("limitedUseAmountLabel", value);
            return entity;
        }

        public static T SetLimitedUseGroup<T>(this T entity, RectTransform value)
            where T : CharacterActionItemForm
        {
            entity.SetField("limitedUseGroup", value);
            return entity;
        }

        public static T SetLimitedUseImage<T>(this T entity, Image value)
            where T : CharacterActionItemForm
        {
            entity.SetField("limitedUseImage", value);
            return entity;
        }

        public static T SetPointerEnter<T>(this T entity, CharacterActionItemForm.PointerEnterHandler value)
            where T : CharacterActionItemForm
        {
            entity.SetField("<PointerEnter>k__BackingField", value);
            return entity;
        }

        public static T SetPointerExit<T>(this T entity, CharacterActionItemForm.PointerExitHandler value)
            where T : CharacterActionItemForm
        {
            entity.SetField("<PointerExit>k__BackingField", value);
            return entity;
        }

        public static T SetScope<T>(this T entity, ActionScope value)
            where T : CharacterActionItemForm
        {
            entity.SetField("scope", value);
            return entity;
        }

        public static T SetStackCountGroup<T>(this T entity, RectTransform value)
            where T : CharacterActionItemForm
        {
            entity.SetField("stackCountGroup", value);
            return entity;
        }

        public static T SetStackCountLabel<T>(this T entity, GuiLabel value)
            where T : CharacterActionItemForm
        {
            entity.SetField("stackCountLabel", value);
            return entity;
        }

        public static T SetTooltip<T>(this T entity, GuiTooltip value)
            where T : CharacterActionItemForm
        {
            entity.SetField("tooltip", value);
            return entity;
        }
    }
}