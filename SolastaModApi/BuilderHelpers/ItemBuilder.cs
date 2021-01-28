
using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace SolastaModApi
{
    class ItemBuilder
    {
        public static ItemDefinition CopyFromItemSetFunctions(List<FeatureDefinitionPower> functions, ItemDefinition toCopy, string name, GuiPresentation guiPresentation)
        {
            ItemDefinition item = ScriptableObject.CreateInstance<ItemDefinition>();

            DoCopy(toCopy, item);

            if (item.UsableDeviceDescription == null)
            {
                Traverse.Create(item).Field("usableDeviceDescription").SetValue(new UsableDeviceDescription());
            }
            if (item.UsableDeviceDescription.DeviceFunctions == null)
            {
                Traverse.Create(item.UsableDeviceDescription).Field("deviceFunctions").SetValue(new List<DeviceFunctionDescription>());
            }

            item.SlotTypes.AddRange(toCopy.SlotTypes);
            item.SlotsWhereActive.AddRange(toCopy.SlotsWhereActive);
            item.ItemTags.AddRange(toCopy.ItemTags);
            item.ActiveTags.AddRange(toCopy.ActiveTags);
            item.InactiveTags.AddRange(toCopy.InactiveTags);
            Traverse.Create(item).Field("canBeStacked").SetValue(true);
            Traverse.Create(item).Field("isUsableDevice").SetValue(true);
            Traverse.Create(item).Field("armorDefinition").SetValue(new ArmorDescription());
            Traverse.Create(item).Field("weaponDefinition").SetValue(new WeaponDescription());
            Traverse.Create(item).Field("ammunitionDefinition").SetValue(new AmmunitionDescription());
            Traverse.Create(item).Field("toolDefinition").SetValue(new ToolDescription());
            Traverse.Create(item).Field("starterPackDefinition").SetValue(new StarterPackDescription());
            Traverse.Create(item).Field("containerItemDefinition").SetValue(new ContainerItemDescription());
            Traverse.Create(item).Field("lightSourceItemDefinition").SetValue(new LightSourceItemDescription());
            Traverse.Create(item).Field("focusItemDefinition").SetValue(new FocusItemDescription());
            Traverse.Create(item).Field("wealthPileDefinition").SetValue(new WealthPileDescription());
            Traverse.Create(item).Field("spellbookDefinition").SetValue(new SpellbookDescription());
            Traverse.Create(item).Field("documentDescription").SetValue(new DocumentDescription());
            Traverse.Create(item).Field("factionRelicDescription").SetValue(new FactionRelicDescription());

            Traverse.Create(item).Field("personalityFlagOccurences").SetValue(new List<PersonalityFlagOccurence>());
            Traverse.Create(item).Field("soundEffectDescriptionOverride").SetValue(new SoundEffectDescription());
            Traverse.Create(item).Field("soundEffectOnHitDescriptionOverride").SetValue(new SoundEffectOnHitDescription());
            Traverse.Create(item).Field("itemPresentation").SetValue(new ItemPresentation());
            Traverse.Create(item).Field("requiredAttunementClasses").SetValue(new List<CharacterClassDefinition>());


            item.UsableDeviceDescription.DeviceFunctions.Clear();

            foreach (FeatureDefinitionPower power in functions)
            {
                DeviceFunctionDescription functionDescription = new DeviceFunctionDescription();
                Traverse.Create(functionDescription).Field("type").SetValue(DeviceFunctionDescription.FunctionType.Power);
                Traverse.Create(functionDescription).Field("featureDefinitionPower").SetValue(power);
                item.UsableDeviceDescription.DeviceFunctions.Add(functionDescription);
            }

            Traverse.Create(item).Field("name").SetValue(name);
            item.name = name;
            Traverse.Create(item).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(item).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<ItemDefinition>().Add(item);

            return item;
        }

        private static void DoCopy(ItemDefinition from, ItemDefinition to)
        {
            foreach (FieldInfo field in typeof(ItemDefinition).GetFields().Where(p => !p.IsStatic))
            {
                field.SetValue(to, field.GetValue(from));
            }

            foreach (PropertyInfo property in typeof(ItemDefinition).GetProperties().Where(p => p.CanWrite))
            {
                property.SetValue(to, property.GetValue(from));
            }
        }
    }
}
