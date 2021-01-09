
using HarmonyLib;
using UnityEngine;

namespace SolastaModApi
{
    class RestActivityBuilder
    {
        public static RestActivityDefinition BuildRestActivity(RestDefinitions.RestStage restStage, RuleDefinitions.RestType restType, RestActivityDefinition.ActivityCondition condition,
            string functor, string stringParameter, string name, GuiPresentation guiPresentation)
        {
            RestActivityDefinition restActivity = ScriptableObject.CreateInstance<RestActivityDefinition>();
            Traverse.Create(restActivity).Field("restStage").SetValue(restStage);
            Traverse.Create(restActivity).Field("restType").SetValue(restType);
            Traverse.Create(restActivity).Field("condition").SetValue(condition);
            Traverse.Create(restActivity).Field("functor").SetValue(functor);
            Traverse.Create(restActivity).Field("stringParameter").SetValue(stringParameter);

            Traverse.Create(restActivity).Field("name").SetValue(name);
            restActivity.name = name;
            Traverse.Create(restActivity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(restActivity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<RestActivityDefinition>().Add(restActivity);
            return restActivity;
        }
    }
}
