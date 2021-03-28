using HarmonyLib;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    class GuiPresentationBuilder
    {
        GuiPresentation guiPresentation;

        public GuiPresentationBuilder(string description, string title)
        {
            guiPresentation = new GuiPresentation();
            guiPresentation.Description = description;
            guiPresentation.Title = title;

            Traverse.Create(guiPresentation).Field("spriteReference").SetValue(new AssetReferenceSprite(""));
        }

        public void SetColor(Color color)
        {
            Traverse.Create(guiPresentation).Field("color").SetValue(color);
        }

        public void SetSortOrder(int sortOrder)
        {
            Traverse.Create(guiPresentation).Field("sortOrder").SetValue(sortOrder);
        }

        public void SetSpriteReference(AssetReferenceSprite sprite)
        {
            Traverse.Create(guiPresentation).Field("spriteReference").SetValue(sprite);
        }

        public GuiPresentation Build()
        {
            return guiPresentation;
        }
    }
}
