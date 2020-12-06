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
        }

        public void SetColor(Color color)
        {
            Traverse.Create(guiPresentation).Field("color").SetValue(new Color(1.0f, 1.0f, 1.0f, 1.0f));
        }

        public void SetSortOrder(int sortOrder)
        {
            Traverse.Create(guiPresentation).Field("sortOrder").SetValue(1);
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
