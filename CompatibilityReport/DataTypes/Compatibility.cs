﻿using System;
using System.Collections.Generic;
using System.Linq;
using CompatibilityReport.Util;


namespace CompatibilityReport.DataTypes
{
    // Needs to be public for XML serialization
    [Serializable] public class Compatibility
    {
        // Steam IDs of two mods
        public ulong SteamID1 { get; private set; }

        public ulong SteamID2 { get; private set; }

        // Compatibility status of these two mods, from the perspective of ID1 ('this mod'); can be one or more statuses
        public List<Enums.CompatibilityStatus> Statuses { get; private set; } = new List<Enums.CompatibilityStatus>();

        // Note about this compatibility
        public string Note { get; private set; }

        // Default constructor
        public Compatibility()
        {
            // Nothing to do here
        }


        // Constructor with all parameters
        internal Compatibility(ulong steamID1, ulong steamID2, List<Enums.CompatibilityStatus> statuses, string note)
        {
            if (steamID1 == steamID2)
            {
                Logger.Log($"Found ModCompatibility object with two identical Steam IDs: { SteamID1 }.", Logger.warning);

                // Overwrite status to avoid weird reporting of a mod being incompatible with itself
                statuses = new List<Enums.CompatibilityStatus> { Enums.CompatibilityStatus.Unknown };
            }

            SteamID1 = steamID1;

            SteamID2 = steamID2;

            if (statuses?.Any() != true)
            {
                // If no status is indicated, add an Unknown so we have at least one
                Statuses = new List<Enums.CompatibilityStatus> { Enums.CompatibilityStatus.Unknown };

                Logger.Log($"Found ModCompatibility object with no status, Steam IDs: { SteamID1 } and { SteamID2 }.", Logger.error);
            }
            else
            {
                Statuses = statuses;
            }

            Note = note ?? "";
        }
    }
}