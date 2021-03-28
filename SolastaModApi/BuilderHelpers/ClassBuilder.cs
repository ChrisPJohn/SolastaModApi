
using HarmonyLib;
using TA.AI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using static CharacterClassDefinition;

namespace SolastaModApi
{
    class ClassBuilder
    {
        CharacterClassDefinition MyClass;

        public ClassBuilder()
        {
            MyClass = ScriptableObject.CreateInstance<CharacterClassDefinition>();
        }

        public void SetHitDice(RuleDefinitions.DieType die)
        {
            Traverse.Create(MyClass).Field("hitDice").SetValue(die);
        }

        public void SetAbilityScorePriorities(string first, string second, string third, string fourth, string fifth, string sixth)
        {
            MyClass.AbilityScoresPriority.Add(first);
            MyClass.AbilityScoresPriority.Add(second);
            MyClass.AbilityScoresPriority.Add(third);
            MyClass.AbilityScoresPriority.Add(fourth);
            MyClass.AbilityScoresPriority.Add(fifth);
            MyClass.AbilityScoresPriority.Add(sixth);
        }

        public void AddPersonality(PersonalityFlagDefinition personalityType, int weight)
        {
            PersonalityFlagOccurence personality = new PersonalityFlagOccurence();
            Traverse.Create(personality).Field("weight").SetValue(weight);
            Traverse.Create(personality).Field("personalityFlag").SetValue(personalityType.Name);
            MyClass.PersonalityFlagOccurences.Add(personality);
        }

        public void AddToolPreference(ToolTypeDefinition toolType)
        {
            MyClass.ToolAutolearnPreference.Add(toolType.Name);
        }

        public void AddSkillPreference(SkillDefinition skillType)
        {
            MyClass.SkillAutolearnPreference.Add(skillType.Name);
        }

        public void AddExpertisePreference(SkillDefinition skillType)
        {
            MyClass.ExpertiseAutolearnPreference.Add(skillType.Name);
        }

        public void AddExpertisePreference(ToolTypeDefinition toolType)
        {
            MyClass.ExpertiseAutolearnPreference.Add(toolType.Name);
        }

        public void AddFeatPreference(FeatDefinition featType)
        {
            MyClass.FeatAutolearnPreference.Add(featType.Name);
        }

        public void SetIngredientGatheringOdds(int odds)
        {
            Traverse.Create(MyClass).Field("ingredientGatheringOdds").SetValue(odds);
        }

        public void SetBattleAI(DecisionPackageDefinition decisionPackage)
        {
            Traverse.Create(MyClass).Field("defaultBattleDecisions").SetValue(decisionPackage);
        }

        public void SetPictogram(AssetReferenceSprite sprite)
        {
            Traverse.Create(MyClass).Field("classPictogramReference").SetValue(sprite);
        }

        public void SetAnimationId(AnimationDefinitions.ClassAnimationId animId)
        {
            Traverse.Create(MyClass).Field("classAnimationId").SetValue(animId);
        }

        public void RequireDeity()
        {
            Traverse.Create(MyClass).Field("requiresDeity").SetValue(true);
        }

        public void SetName(string name)
        {
            Traverse.Create(MyClass).Field("name").SetValue(name);
            MyClass.name = name;
            Traverse.Create(MyClass).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(MyClass).Field("guiPresentation").SetValue(gui);
        }

        public void AddEquipmentRow(List<HeroEquipmentOption> equipmentList)
        {
            HeroEquipmentRow equipmentRow = new HeroEquipmentRow();
            HeroEquipmentColumn equipmentColumn = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentList)
            {
                equipmentColumn.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumn);
            MyClass.EquipmentRows.Add(equipmentRow);
        }

        public void AddEquipmentRow(List<HeroEquipmentOption> equipmentListA, List<HeroEquipmentOption> equipmentListB)
        {
            HeroEquipmentRow equipmentRow = new HeroEquipmentRow();
            HeroEquipmentColumn equipmentColumnA = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentListA)
            {
                equipmentColumnA.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumnA);
            HeroEquipmentColumn equipmentColumnB = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentListB)
            {
                equipmentColumnB.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumnB);
            MyClass.EquipmentRows.Add(equipmentRow);
        }

        public void AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            MyClass.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
        }

        public FeatureDefinitionSubclassChoice BuildSubclassChoice(int level, string subclassSuffix, bool requireDeity, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionSubclassChoice subclassChoice = ScriptableObject.CreateInstance<FeatureDefinitionSubclassChoice>();
            Traverse.Create(subclassChoice).Field("filterByDeity").SetValue(requireDeity);
            Traverse.Create(subclassChoice).Field("subclassSuffix").SetValue(subclassSuffix);
            Traverse.Create(subclassChoice).Field("name").SetValue(name);
            subclassChoice.name = name;
            Traverse.Create(subclassChoice).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(subclassChoice).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());

            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(subclassChoice);
            AddFeatureAtLevel(subclassChoice, level);
            return subclassChoice;
        }

        public CharacterClassDefinition AddToDB()
        {
            Database<CharacterClassDefinition> CharacterClassDatabase = DatabaseRepository.GetDatabase<CharacterClassDefinition>();
            // add new class to db
            CharacterClassDatabase.Add(MyClass);
            return MyClass;
        }
    }
}
