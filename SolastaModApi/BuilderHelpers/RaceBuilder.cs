
using HarmonyLib;
using UnityEngine;

namespace SolastaModApi
{
    class RaceBuilder
    {
        CharacterRaceDefinition MyRace;

        public RaceBuilder()
        {
            MyRace = ScriptableObject.CreateInstance<CharacterRaceDefinition>();
        }

        public void SetName(string name)
        {
            Traverse.Create(MyRace).Field("name").SetValue(name);
            MyRace.name = name;
            Traverse.Create(MyRace).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
        }

        /**
         * Make sure this is set for base races.
         */
        public void SetAge(int minAge, int maxAge)
        {
            Traverse.Create(MyRace).Field("minimalAge").SetValue(minAge);
            Traverse.Create(MyRace).Field("maximalAge").SetValue(maxAge);
        }

        /**
         * Make sure this is set for subraces.
         */
        public void SetHeightWeight(int height, int weight)
        {
            Traverse.Create(MyRace).Field("baseHeight").SetValue(height);
            Traverse.Create(MyRace).Field("baseWeight").SetValue(weight);
        }

        public void SetDualSex(bool dualSex)
        {
            Traverse.Create(MyRace).Field("dualSex").SetValue(dualSex);
        }

        public void SetSize(CharacterSizeDefinition size)
        {
            MyRace.SizeDefinition = size;
        }

        public void SetAlignment(AlignmentDefinition alignment)
        {
            Traverse.Create(MyRace).Field("defaultAlignment").SetValue(alignment.Name);
        }

        public void SetInventoryType(InventoryDefinition inventory)
        {
            Traverse.Create(MyRace).Field("inventoryDefinition").SetValue(inventory);
        }

        public void AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            MyRace.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
        }

        public void AddPersonality(PersonalityFlagDefinition personalityType, int weight)
        {
            PersonalityFlagOccurence personality = new PersonalityFlagOccurence();
            Traverse.Create(personality).Field("weight").SetValue(weight);
            Traverse.Create(personality).Field("personalityFlag").SetValue(personalityType.Name);
            MyRace.PersonalityFlagOccurences.Add(personality);
        }

        public void AddLanguagePreference(LanguageDefinition language)
        {
            MyRace.LanguageAutolearnPreference.Add(language.Name);
        }

        public void SetRacePresentation(RacePresentation presentation)
        {
            Traverse.Create(MyRace).Field("racePresentation").SetValue(presentation);
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(MyRace).Field("guiPresentation").SetValue(gui);
        }

        public void AddSubRace(CharacterRaceDefinition subrace)
        {
            MyRace.SubRaces.Add(subrace);
        }

        public CharacterRaceDefinition AddToDB()
        {
            Database<CharacterRaceDefinition> CharacterRaceDatabase = DatabaseRepository.GetDatabase<CharacterRaceDefinition>();
            // add new race to db
            CharacterRaceDatabase.Add(MyRace);
            return MyRace;
        }
    }
}
