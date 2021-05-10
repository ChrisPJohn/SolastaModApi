using SolastaModApi.Extensions;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public class GuiPresentationBuilder
    {
        private readonly GuiPresentation guiPresentation;

        public GuiPresentationBuilder(string description, string title)
        {
            guiPresentation = new GuiPresentation
            {
                Description = description,
                Title = title
            };

            SetSpriteReference(new AssetReferenceSprite(string.Empty));
        }

        public GuiPresentationBuilder SetColor(Color color)
        {
            guiPresentation.SetColor(color);
            return this;
        }

        public GuiPresentationBuilder SetSortOrder(int sortOrder)
        {
            guiPresentation.SetSortOrder(sortOrder);
            return this;
        }

        public GuiPresentationBuilder SetSpriteReference(AssetReferenceSprite sprite)
        {
            guiPresentation.SetSpriteReference(sprite);
            return this;
        }

        public GuiPresentation Build()
        {
            return guiPresentation;
        }
    }
}
