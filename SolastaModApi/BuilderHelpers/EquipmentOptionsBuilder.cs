using HarmonyLib;
using static CharacterClassDefinition;

namespace SolastaModApi
{
    public class EquipmentOptionsBuilder
    {
        public static HeroEquipmentOption Option(ItemDefinition itemType, string optionType, int number)
        {
            HeroEquipmentOption itemOption = new HeroEquipmentOption();
            Traverse.Create(itemOption).Field("number").SetValue(number);
            Traverse.Create(itemOption).Field("optionType").SetValue(optionType);
            Traverse.Create(itemOption).Field("itemReference").SetValue(itemType);
            return itemOption;
        }

        public static HeroEquipmentOption Option(string defaultChoice, string optionType, int number)
        {
            HeroEquipmentOption itemOption = new HeroEquipmentOption();
            Traverse.Create(itemOption).Field("number").SetValue(number);
            Traverse.Create(itemOption).Field("optionType").SetValue(optionType);
            Traverse.Create(itemOption).Field("defaultChoice").SetValue(defaultChoice);
            return itemOption;
        }
    }
}
