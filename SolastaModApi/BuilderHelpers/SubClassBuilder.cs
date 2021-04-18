
using HarmonyLib;
using UnityEngine;

namespace SolastaModApi
{
    public class SubClassBuilder
    {
        private readonly CharacterSubclassDefinition myClass;

        public SubClassBuilder()
        {
            myClass = ScriptableObject.CreateInstance<CharacterSubclassDefinition>();
        }

        public void SetName(string name, string guid)
        {
            Traverse.Create(myClass).Field("name").SetValue(name);
            myClass.name = name;
            Traverse.Create(myClass).Field("guid").SetValue(guid);
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(myClass).Field("guiPresentation").SetValue(gui);
        }

        public void AddPersonality(PersonalityFlagDefinition personalityType, int weight)
        {
            PersonalityFlagOccurence personality = new PersonalityFlagOccurence();
            Traverse.Create(personality).Field("weight").SetValue(weight);
            Traverse.Create(personality).Field("personalityFlag").SetValue(personalityType.Name);
            myClass.PersonalityFlagOccurences.Add(personality);
        }

        public void AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            myClass.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
        }

        public CharacterSubclassDefinition AddToDB()
        {
            Database<CharacterSubclassDefinition> CharacterSubClassDatabase = DatabaseRepository.GetDatabase<CharacterSubclassDefinition>();
            // add new class to db
            CharacterSubClassDatabase.Add(myClass);
            return myClass;
        }
    }
}
