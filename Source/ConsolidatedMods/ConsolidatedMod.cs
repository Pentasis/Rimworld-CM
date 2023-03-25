using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace ConsolidatedMods {

    public class ConsolidatedMod : Mod {

        public ConsolidatedMod(ModContentPack content) : base(content) {
            Harmony harmony = new Harmony("mod.pentasis.consolidatedmods");

        }
    }
}
