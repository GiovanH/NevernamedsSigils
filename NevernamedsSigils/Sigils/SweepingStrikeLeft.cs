﻿using APIPlugin;
using DiskCardGame;
using InscryptionAPI.Triggers;
using Pixelplacement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace NevernamedsSigils
{
    public class SweepingStrikeLeft : AbilityBehaviour
    {
        public static void Init()
        {
            AbilityInfo newSigil = SigilSetupUtility.MakeNewSigil("Sweeping Strike Left", "[creature] will always attack the leftmost opponent creature. Overkill damage travels to the right instead of to the backlane.",
                      typeof(SweepingStrikeLeft),
                      categories: new List<AbilityMetaCategory> { AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part1Modular, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook, AbilityMetaCategory.Part3BuildACard, AbilityMetaCategory.Part3Modular, AbilityMetaCategory.Part3Rulebook, Plugin.Part2Modular, Plugin.GrimoraModChair2 },
                      powerLevel: 1,
                      stackable: false,
                      opponentUsable: true,
                      tex: Tools.LoadTex("NevernamedsSigils/Resources/Sigils/sweepingstrikeleft.png"),
                      pixelTex: Tools.LoadTex("NevernamedsSigils/Resources/PixelSigils/sweepingstrikeleft_pixel.png"));

            ability = newSigil.ability;
        }
        public static Ability ability;
        public override Ability Ability
        {
            get
            {
                return ability;
            }
        }
    }
}