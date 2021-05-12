using SolastaModApi.Diagnostics;
using SolastaModApi.Extensions;
using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public class CastSpellBuilder : BaseDefinitionBuilder<FeatureDefinitionCastSpell>
    {
        public enum CasterProgression
        {
            FULL_CASTER,
            HALF_CASTER,
            THIRD_CASTER
        }

        public CastSpellBuilder(string name, string guid) : base(name, guid)
        {
            InitializeFields();
        }

        private void InitializeFields()
        {
            Definition.SetField("restrictedSchools", new List<string>());

            SetKnownCantripsZero();
            SetKnownZero();
            SetScribedZero();
        }

        public CastSpellBuilder SetGuiPresentation(GuiPresentation gui)
        {
            Definition.SetGuiPresentation(gui);
            return this;
        }

        public CastSpellBuilder SetSpellCastingOrigin(FeatureDefinitionCastSpell.CastingOrigin origin)
        {
            Definition.SetSpellCastingOrigin(origin);
            return this;
        }

        public CastSpellBuilder SetSpellCastingAbility(string attribute)
        {
            Definition.SetSpellcastingAbility(attribute);
            return this;
        }

        public CastSpellBuilder SetStaticParameters(int dcValue, int toHitValue)
        {
            Definition.SetSpellcastingParametersComputation(RuleDefinitions.SpellcastingParametersComputation.Static);
            Definition.SetStaticDCValue(dcValue);
            Definition.SetStaticToHitValue(toHitValue);
            return this;
        }

        public CastSpellBuilder SetSpellList(SpellListDefinition spellList)
        {
            Definition.SetSpellListDefinition(spellList);
            return this;
        }

        public CastSpellBuilder SetSpellKnowledge(RuleDefinitions.SpellKnowledge knowledge)
        {
            Definition.SetSpellKnowledge(knowledge);
            return this;
        }

        public CastSpellBuilder SetSpellReadyness(RuleDefinitions.SpellReadyness readyness)
        {
            Definition.SetSpellReadyness(readyness);
            return this;
        }

        public CastSpellBuilder SetSpellPreparationCount(RuleDefinitions.SpellPreparationCount prepCount)
        {
            Definition.SetSpellPreparationCount(prepCount);
            return this;
        }

        public CastSpellBuilder SetSlotsRecharge(RuleDefinitions.RechargeRate slotRecharge)
        {
            Definition.SetSlotsRecharge(slotRecharge);
            return this;
        }

        public CastSpellBuilder SetSpellCastingLevel(int level)
        {
            Definition.SetSpellCastingLevel(level);
            return this;
        }

        public CastSpellBuilder AddRestrictedSchool(SchoolOfMagicDefinition school)
        {
            Definition.RestrictedSchools.Add(school.Name);
            return this;
        }

        public CastSpellBuilder SetKnownCantrips(List<int> cantripsCount)
        {
            Definition.KnownCantrips.Clear();
            Definition.KnownCantrips.AddRange(cantripsCount);
            return this;
        }

        public CastSpellBuilder SetKnown(List<int> spellsCount)
        {
            Definition.KnownSpells.Clear();
            Definition.KnownSpells.AddRange(spellsCount);
            return this;
        }

        public CastSpellBuilder SetScribed(List<int> scribedCount)
        {
            Definition.ScribedSpells.Clear();
            Definition.ScribedSpells.AddRange(scribedCount);
            return this;
        }

        public CastSpellBuilder SetSlotsPerLevel(List<FeatureDefinitionCastSpell.SlotsByLevelDuplet> slotsPerLevels)
        {
            Definition.SlotsPerLevels.Clear();
            Definition.SlotsPerLevels.AddRange(slotsPerLevels);
            return this;
        }

        private void SetKnownCantripsZero()
        {
            Definition.KnownCantrips.Clear();
            for (int level = 1; level < 21; level++)
            {
                Definition.KnownCantrips.Add(0);
            }
        }

        public CastSpellBuilder SetKnownCantrips(int startingAmount, int startingLevel, CasterProgression progression)
        {
            Definition.KnownCantrips.Clear();
            int level = 1;
            int numCantrips = 0;
            for (; level < startingLevel; level++)
            {
                Definition.KnownCantrips.Add(numCantrips);
            }
            numCantrips = startingAmount;
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 4; level++)
                    {
                        Definition.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 10; level++)
                    {
                        Definition.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        Definition.KnownCantrips.Add(numCantrips);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 10; level++)
                    {
                        Definition.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 14; level++)
                    {
                        Definition.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        Definition.KnownCantrips.Add(numCantrips);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 10; level++)
                    {
                        Definition.KnownCantrips.Add(numCantrips);
                    }
                    numCantrips++;
                    for (; level < 21; level++)
                    {
                        Definition.KnownCantrips.Add(numCantrips);
                    }
                    break;
                default:
                    throw new SolastaModApiException($"Unknown CasterProgression: {progression}");
            }
            return this;
        }

        private void SetScribedZero()
        {
            Definition.ScribedSpells.Clear();
            for (int level = 1; level < 21; level++)
            {
                Definition.ScribedSpells.Add(0);
            }
        }

        public CastSpellBuilder SetScribedSpells(int startingLevel, int initialAmount, int perLevelAfterFirst)
        {
            Definition.ScribedSpells.Clear();
            int level = 1;
            for (; level < startingLevel; level++)
            {
                Definition.ScribedSpells.Add(0);
            }
            Definition.ScribedSpells.Add(initialAmount);
            level++;
            for (; level < 21; level++)
            {
                Definition.ScribedSpells.Add(perLevelAfterFirst);
            }
            return this;
        }

        private void SetKnownZero()
        {
            Definition.KnownSpells.Clear();
            for (int level = 1; level < 21; level++)
            {
                Definition.KnownSpells.Add(0);
            }
        }

        private readonly int[] BonusSpellsKnownByCasterLevel = { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 11, 11, 12, 12, 13, 13, 13, 13 };
        private readonly int[] BonusSpellsKnownThirdCaster = { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4 };

        public CastSpellBuilder SetKnownSpells(int startingAmount, int startingLevel, CasterProgression progression)
        {
            Definition.KnownSpells.Clear();
            int level = 1;
            for (; level < startingLevel; level++)
            {
                Definition.KnownSpells.Add(0);
            }
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 21; level++)
                    {
                        Definition.KnownSpells.Add(startingAmount + BonusSpellsKnownByCasterLevel[level]);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 21; level++)
                    {
                        // +1 here because half casters effectively round up the spells known
                        Definition.KnownSpells.Add(startingAmount + BonusSpellsKnownByCasterLevel[(level + 1) / 2]);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 21; level++)
                    {

                        Definition.KnownSpells.Add(startingAmount +
                            // +2 here because third casters effectively "round up" for spells known
                            BonusSpellsKnownByCasterLevel[(level + 2) / 3] +
                            // Third casters also just learn spells faster
                            BonusSpellsKnownThirdCaster[level]);
                    }
                    break;
                default:
                    throw new SolastaModApiException($"Unknown CasterProgression: {progression}");
            }
            return this;
        }

        private readonly List<int>[] SlotsByCasterLevel = 
        {
            new List<int> {0,0,0,0,0 },
            new List<int> {2,0,0,0,0 },
            new List<int> {3,0,0,0,0 },
            new List<int> {4,2,0,0,0 },
            new List<int> {4,3,0,0,0 },
            new List<int> {4,3,2,0,0 },
            new List<int> {4,3,3,0,0 },
            new List<int> {4,3,3,1,0 },
            new List<int> {4,3,3,2,0 },
            new List<int> {4,3,3,3,1 },
            new List<int> {4,3,3,3,2 },
            new List<int> {4,3,3,3,2 },
            new List<int> {4,3,3,3,2 },
            new List<int> {4,3,3,3,2 },
            new List<int> {4,3,3,3,2 },
            new List<int> {4,3,3,3,2 },
            new List<int> {4,3,3,3,2 },
            new List<int> {4,3,3,3,2 },
            new List<int> {4,3,3,3,3 },
            new List<int> {4,3,3,3,3 },
            new List<int> {4,3,3,3,3 },
        };

        public CastSpellBuilder SetSlotsPerLevel(int startingLevel, CasterProgression progression)
        {
            int level = 1;
            for (; level < startingLevel; level++)
            {
                FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet
                {
                    Level = level,
                    Slots = SlotsByCasterLevel[0]
                };
                Definition.SlotsPerLevels.Add(slotsForLevel);
            }
            switch (progression)
            {
                case CasterProgression.FULL_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet
                        {
                            Level = level,
                            Slots = SlotsByCasterLevel[level - startingLevel + 1]
                        };
                        Definition.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
                case CasterProgression.HALF_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet
                        {
                            Level = level,
                            Slots = SlotsByCasterLevel[(level - startingLevel) / 2 + 1]
                        };
                        Definition.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
                case CasterProgression.THIRD_CASTER:
                    for (; level < 21; level++)
                    {
                        FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsForLevel = new FeatureDefinitionCastSpell.SlotsByLevelDuplet
                        {
                            Level = level,
                            Slots = SlotsByCasterLevel[(level - startingLevel + 2) / 3 + 1]
                        };
                        Definition.SlotsPerLevels.Add(slotsForLevel);
                    }
                    break;
            }
            return this;
        }
    }
}