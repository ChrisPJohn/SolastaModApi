

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace SolastaModApi
{
    public class CastSpellBuilder
    {
        private readonly FeatureDefinitionCastSpell castSpell;

        public enum CasterProgression
        {
            FULL_CASTER,
            HALF_CASTER,
            THIRD_CASTER,
        }

        public CastSpellBuilder()
        {
            castSpell = ScriptableObject.CreateInstance<FeatureDefinitionCastSpell>();
            Traverse.Create(castSpell).Field("restrictedSchools").SetValue(new List<string>());

            SetKnownCantripsZero();
            SetKnownZero();
            SetScribedZero();
        }

        public void SetName(string name, string guid)
        {
            Traverse.Create(castSpell).Field("name").SetValue(name);
            castSpell.name = name;
            Traverse.Create(castSpell).Field("guid").SetValue(guid);
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(castSpell).Field("guiPresentation").SetValue(gui);
        }

        public void SetSpellCastingOrigin(FeatureDefinitionCastSpell.CastingOrigin origin)
        {
            Traverse.Create(castSpell).Field("spellCastingOrigin").SetValue(origin);
        }

        public void SetSpellCastingAbility(string attribute)
        {
            Traverse.Create(castSpell).Field("spellcastingAbility").SetValue(attribute);
        }

        public void SetStaticParameters(int dcValue, int toHitValue)
        {
            Traverse.Create(castSpell).Field("spellcastingParametersComputation").SetValue(RuleDefinitions.SpellcastingParametersComputation.Static);
            Traverse.Create(castSpell).Field("staticDCValue").SetValue(dcValue);
            Traverse.Create(castSpell).Field("staticToHitValue").SetValue(toHitValue);
        }

        public void SetSpellList(SpellListDefinition spellList)
        {
            Traverse.Create(castSpell).Field("spellListDefinition").SetValue(spellList);
        }

        public void SetSpellKnowledge(RuleDefinitions.SpellKnowledge knowledge)
        {
            Traverse.Create(castSpell).Field("spellKnowledge").SetValue(knowledge);
        }

        public void SetSpellReadyness(RuleDefinitions.SpellReadyness readyness)
        {
            Traverse.Create(castSpell).Field("spellReadyness").SetValue(readyness);
        }

        public void SetSpellPreparationCount(RuleDefinitions.SpellPreparationCount prepCount)
        {
            Traverse.Create(castSpell).Field("spellPreparationCount").SetValue(prepCount);
        }

        public void SetSlotsRecharge(RuleDefinitions.RechargeRate slotRecharge)
        {
            Traverse.Create(castSpell).Field("slotsRecharge").SetValue(slotRecharge);
        }

        public void SetCanUseScrolls(bool scrolls)
        {
            Traverse.Create(castSpell).Field("canUseScrolls").SetValue(scrolls);
        }

        public void SetSpellCastingLevel(int level)
        {
            Traverse.Create(castSpell).Field("spellCastingLevel").SetValue(level);
        }

        public void AddRestrictedSchool(SchoolOfMagicDefinition school)
        {
            castSpell.RestrictedSchools.Add(school.Name);
        }

        public void SetKnownCantrips(List<int> cantripsCount)
        {
            Traverse.Create(castSpell).Field("knownCantrips").SetValue(cantripsCount);
        }

        public void SetKnown(List<int> spellsCount)
        {
            Traverse.Create(castSpell).Field("knownSpells").SetValue(spellsCount);
        }

        public void SetScribed(List<int> scribedCount)
        {
            Traverse.Create(castSpell).Field("scribedSpells").SetValue(scribedCount);
        }

        public void SetSlotsPerLevel(List<FeatureDefinitionCastSpell.SlotsByLevelDuplet> slotsPerLevels)
        {
            Traverse.Create(castSpell).Field("slotsPerLevels").SetValue(slotsPerLevels);
        }

        private void SetKnownCantripsZero()
        {
            castSpell.KnownCantrips.Clear();
            for (int level = 1; level < 21; level++)
            {
                castSpell.KnownCantrips.Add(0);
            }
        }

        public void SetKnownCantrips(int startingAmount, int startingLevel, CasterProgression progression)
        {
            castSpell.KnownCantrips.Clear();
            int level = 1;
            int numCantrips = 0;
            for (; level < startingLevel; level++)
            {
                castSpell.KnownCantrips.Add(numCantrips);
            }
            numCantrips = startingAmount;
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 4; level++)
                    {
                        castSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 10; level++)
                    {
                        castSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        castSpell.KnownCantrips.Add(numCantrips);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 10; level++)
                    {
                        castSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 14; level++)
                    {
                        castSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        castSpell.KnownCantrips.Add(numCantrips);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 10; level++)
                    {
                        castSpell.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        castSpell.KnownCantrips.Add(numCantrips);
                    }
                    break;
            }
        }

        private void SetScribedZero()
        {
            castSpell.ScribedSpells.Clear();
            for (int level = 1; level < 21; level++)
            {
                castSpell.ScribedSpells.Add(0);
            }
        }

        public void SetScribedSpells(int startingLevel, int initialAmount, int perLevelAfterFirst)
        {
            castSpell.ScribedSpells.Clear();
            int level = 1;
            for (; level < startingLevel; level++)
            {
                castSpell.ScribedSpells.Add(0);
            }
            castSpell.ScribedSpells.Add(initialAmount);
            level++;
            for (; level < 21; level++)
            {
                castSpell.ScribedSpells.Add(perLevelAfterFirst);
            }
        }

        private void SetKnownZero()
        {
            castSpell.KnownSpells.Clear();
            for (int level = 1; level < 21; level++)
            {
                castSpell.KnownSpells.Add(0);
            }
        }

        private int[] BonusSpellsKnownByCasterLevel = new int[] { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 11, 11, 12, 12, 13, 13, 13, 13 };
        private int[] BonusSpellsKnownThirdCaster = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4 };

        public void SetKnownSpells(int startingAmount, int startingLevel, CasterProgression progression)
        {
            castSpell.KnownSpells.Clear();
            int level = 1;
            for (; level < startingLevel; level++)
            {
                castSpell.KnownSpells.Add(0);
            }
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 21; level++)
                    {
                        castSpell.KnownSpells.Add(startingAmount + BonusSpellsKnownByCasterLevel[level]);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 21; level++)
                    {
                        // +1 here because half casters effectively round up the spells known
                        castSpell.KnownSpells.Add(startingAmount + BonusSpellsKnownByCasterLevel[(level + 1) / 2]);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 21; level++)
                    {

                        castSpell.KnownSpells.Add(startingAmount +
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
                castSpell.SlotsPerLevels.Add(slotsForLevel);
            }
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet();
                        slotsForLevel.Level = level;
                        slotsForLevel.Slots = SlotsByCasterLevel[level - startingLevel + 1];
                        castSpell.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet();
                        slotsForLevel.Level = level;
                        slotsForLevel.Slots = SlotsByCasterLevel[(level - startingLevel) / 2 + 1];
                        castSpell.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet();
                        slotsForLevel.Level = level;
                        slotsForLevel.Slots = SlotsByCasterLevel[(level - startingLevel + 2) / 3 + 1];
                        castSpell.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
            }
        }

        public FeatureDefinitionCastSpell AddToDB()
        {
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(castSpell);
            return castSpell;
        }
    }
}