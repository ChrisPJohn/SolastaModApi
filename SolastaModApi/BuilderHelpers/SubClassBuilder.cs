
using HarmonyLib;
using UnityEngine;

namespace SolastaModApi
{
    class SubClassBuilder
    {

        CharacterSubclassDefinition MyClass;

        public SubClassBuilder()
        {
            MyClass = ScriptableObject.CreateInstance<CharacterSubclassDefinition>();
        }

        public void SetName(string name, string guid)
        {

            Traverse.Create(MyClass).Field("name").SetValue(name);
            MyClass.name = name;
            Traverse.Create(MyClass).Field("guid").SetValue(guid);
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(MyClass).Field("guiPresentation").SetValue(gui);
        }

        public void AddPersonality(PersonalityFlagDefinition personalityType, int weight)
        {
            PersonalityFlagOccurence personality = new PersonalityFlagOccurence();
            Traverse.Create(personality).Field("weight").SetValue(weight);
            Traverse.Create(personality).Field("personalityFlag").SetValue(personalityType.Name);
            MyClass.PersonalityFlagOccurences.Add(personality);
        }

        public void AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            MyClass.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
        }

        public CharacterSubclassDefinition AddToDB()
        {
            Database<CharacterSubclassDefinition> CharacterSubClassDatabase = DatabaseRepository.GetDatabase<CharacterSubclassDefinition>();
            // add new class to db
            CharacterSubClassDatabase.Add(MyClass);
            return MyClass;
        }
    }
}
