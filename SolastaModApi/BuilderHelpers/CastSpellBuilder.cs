

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace SolastaModApi
{
    class CastSpellBuilder
    {
        FeatureDefinitionCastSpell CastSpell;

        public enum CasterProgression
        {
            FULL_CASTER,
            HALF_CASTER,
            THIRD_CASTER,
        }

        public CastSpellBuilder()
        {
            CastSpell = ScriptableObject.CreateInstance<FeatureDefinitionCastSpell>();
        }

        public void SetName(string name)
        {
            Traverse.Create(CastSpell).Field("name").SetValue(name);
            CastSpell.name = name;
            Traverse.Create(CastSpell).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(CastSpell).Field("guiPresentation").SetValue(gui);
        }

        public void SetSpellCastingOrigin(FeatureDefinitionCastSpell.CastingOrigin origin)
        {
            Traverse.Create(CastSpell).Field("spellCastingOrigin").SetValue(origin);
        }

        public void SetSpellCastingAbility(string attribute)
        {
            Traverse.Create(CastSpell).Field("spellcastingAbility").SetValue(attribute);
        }

        public void SetSpellList(SpellListDefinition spellList)
        {
            Traverse.Create(CastSpell).Field("spellListDefinition").SetValue(spellList);
        }

        public void SetSpellKnowledge(RuleDefinitions.SpellKnowledge knowledge)
        {
            Traverse.Create(CastSpell).Field("spellKnowledge").SetValue(knowledge);
        }

        public void SetSpellReadyness(RuleDefinitions.SpellReadyness readyness)
        {
            Traverse.Create(CastSpell).Field("spellReadyness").SetValue(readyness);
        }

        public void SetSpellPreparationCount(RuleDefinitions.SpellPreparationCount prepCount)
        {
            Traverse.Create(CastSpell).Field("spellPreparationCount").SetValue(prepCount);
        }

        public void SetSlotsRecharge(RuleDefinitions.RechargeRate slotRecharge)
        {
            Traverse.Create(CastSpell).Field("slotsRecharge").SetValue(slotRecharge);
        }

        public void SetCanUseScrolls(bool scrolls)
        {
            Traverse.Create(CastSpell).Field("canUseScrolls").SetValue(scrolls);
        }

        public void SetSpellCastingLevel(int level)
        {
            Traverse.Create(CastSpell).Field("spellCastingLevel").SetValue(level);
        }

        public void AddRestrictedSchool(SchoolOfMagicDefinition school)
        {
            if (CastSpell.RestrictedSchools == null)
            {
                Traverse.Create(CastSpell).Field("restrictedSchools").SetValue(new List<string>());
            }
            CastSpell.RestrictedSchools.Add(school.Name);
        }

        /**
         * Useful to set up a class like Paladin or Ranger that doens't get cantrips.
         */
        public void SetKnownCantripsZero()
        {
            CastSpell.KnownCantrips.Clear();
            for (int level = 1; level < 21; level++)
            {
                CastSpell.KnownCantrips.Add(0);
            }
        }

        public void SetKnownCantrips(int startingAmount, int startingLevel, CasterProgression progression)
        {
            CastSpell.KnownCantrips.Clear();
            int level = 1;
            int numCantrips = 0;
            for (; level < startingLevel; level++)
            {
                CastSpell.KnownCantrips.Add(numCantrips);
            }
            numCantrips = startingAmount;
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 4; level++)
                    {
                        CastSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 10; level++)
                    {
                        CastSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        CastSpell.KnownCantrips.Add(numCantrips);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 10; level++)
                    {
                        CastSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 14; level++)
                    {
                        CastSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        CastSpell.KnownCantrips.Add(numCantrips);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 10; level++)
                    {
                        CastSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        CastSpell.KnownCantrips.Add(numCantrips);
                    }
                    break;
            }
        }

        public void SetScribedZero()
        {
            CastSpell.ScribedSpells.Clear();
            for (int level = 1; level < 21; level++)
            {
                CastSpell.ScribedSpells.Add(0);
            }
        }

        public void SetScribedSpells(int startingLevel, int initialAmount, int perLevelAfterFirst)
        {
            CastSpell.ScribedSpells.Clear();
            int level = 1;
            for (; level < startingLevel; level++)
            {
                CastSpell.ScribedSpells.Add(0);
            }
            CastSpell.ScribedSpells.Add(initialAmount);
            level++;
            for (; level < 21; level++)
            {
                CastSpell.ScribedSpells.Add(perLevelAfterFirst);
            }
        }

        public void SetKnownZero()
        {
            CastSpell.KnownSpells.Clear();
            for (int level = 1; level < 21; level++)
            {
                CastSpell.KnownSpells.Add(0);
            }
        }

        private int[] BonusSpellsKnownByCasterLevel = new int[] { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 11, 11, 12, 12, 13, 13, 13, 13 };
        private int[] BonusSpellsKnownThirdCaster = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4 };

        public void SetKnownSpells(int startingAmount, int startingLevel, CasterProgression progression)
        {
            CastSpell.KnownSpells.Clear();
            int level = 1;
            for (; level < startingLevel; level++)
            {
                CastSpell.KnownSpells.Add(0);
            }
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 21; level++)
                    {
                        CastSpell.KnownSpells.Add(startingAmount + BonusSpellsKnownByCasterLevel[level]);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 21; level++)
                    {
                        // +1 here because half casters effectively round up the spells known
                        CastSpell.KnownSpells.Add(startingAmount + BonusSpellsKnownByCasterLevel[(level + 1) / 2]);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 21; level++)
                    {

                        CastSpell.KnownSpells.Add(startingAmount +
                            // +2 here because third casters effectively "round up" for spells known
                            BonusSpellsKnownByCasterLevel[(level + 2) / 3] +
                            // Third casters also just learn spells faster
                            BonusSpellsKnownThirdCaster[level]);
                    }
                    break;
            }
        }

        private List<int>[] SlotsByCasterLevel = new List<int>[]
        {
            new List<int>() {0,0,0,0,0 },
            new List<int>() {2,0,0,0,0 },
            new List<int>() {3,0,0,0,0 },
            new List<int>() {4,2,0,0,0 },
            new List<int>() {4,3,0,0,0 },
            new List<int>() {4,3,2,0,0 },
            new List<int>() {4,3,3,0,0 },
            new List<int>() {4,3,3,1,0 },
            new List<int>() {4,3,3,2,0 },
            new List<int>() {4,3,3,3,1 },
            new List<int>() {4,3,3,3,2 },
            new List<int>() {4,3,3,3,2 },
            new List<int>() {4,3,3,3,2 },
            new List<int>() {4,3,3,3,2 },
            new List<int>() {4,3,3,3,2 },
            new List<int>() {4,3,3,3,2 },
            new List<int>() {4,3,3,3,2 },
            new List<int>() {4,3,3,3,2 },
            new List<int>() {4,3,3,3,3 },
            new List<int>() {4,3,3,3,3 },
            new List<int>() {4,3,3,3,3 },
        };
        public void SetSlotsPerLevel(int startingLevel, CasterProgression progression)
        {
            int level = 1;
            for (; level < startingLevel; level++)
            {
                FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet();
                slotsForLevel.Level = level;
                slotsForLevel.Slots = SlotsByCasterLevel[0];
                CastSpell.SlotsPerLevels.Add(slotsForLevel);
            }
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet();
                        slotsForLevel.Level = level;
                        slotsForLevel.Slots = SlotsByCasterLevel[level - startingLevel + 1];
                        CastSpell.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet();
                        slotsForLevel.Level = level;
                        slotsForLevel.Slots = SlotsByCasterLevel[(level - startingLevel + 1) / 2 + 1];
                        CastSpell.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet();
                        slotsForLevel.Level = level;
                        slotsForLevel.Slots = SlotsByCasterLevel[(level - startingLevel + 2) / 3 + 1];
                        CastSpell.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
            }
        }

        public FeatureDefinitionCastSpell AddToDB()
        {
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(CastSpell);
            return CastSpell;
        }
    }
}