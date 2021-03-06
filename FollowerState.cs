﻿using System;
using System.Collections.Generic;
using SharpDX;

namespace FollowerV2
{
    internal class FollowerState
    {
        public bool Aggressive = true;

        public ActionsEnum CurrentAction = ActionsEnum.Nothing;

        public int EntranceLogicIterationCount;
        public int LocalEntranceLogicIterationCount;

        public int NormalItemId = 0;

        public int PortalLogicIterationCount;
        public int WaypointLogicIterationCount;
        public int TeleportingLogicIterationCount;
        public uint SavedCurrentAreaHash;
        public Vector3 SavedCurrentPos = Vector3.Zero;

        public bool ShouldLevelUpGems = false;
        public bool ShouldFollowThroughEntrances = false;
        public DateTime LastTimeEntranceUsedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime SavedLastTimeEntranceUsedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime LastTimePortalUsedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime SavedLastTimePortalUsedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime LastTimeWaypointUsedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public DateTime LastTimeTeleportedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime SavedLastTimeWaypointUsedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime SavedLastTimeTeleportedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public DateTime LastTimeQuestItemPickupDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime SavedLastTimeQuestItemPickupDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime LastTimeNormalItemPickupDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime SavedLastTimeNormalItemPickupDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime LastTimeEnterHideoutUsedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime SavedLastTimeEnterHideoutUsedDateTime { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public string HideoutCharacterName { get; set; } = "";

        public List<FollowerSkill> FollowerSkills { get; set; } = new List<FollowerSkill>();

        public DateTime LastTimeLevelUpGemsCompositeRan { get; set; } =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public void ResetAreaChangingValues()
        {
            EntranceLogicIterationCount = 0;
            SavedCurrentPos = Vector3.Zero;
            SavedCurrentAreaHash = 0;
            PortalLogicIterationCount = 0;
            WaypointLogicIterationCount = 0;
            TeleportingLogicIterationCount = 0;
        }
    }

    public enum ActionsEnum
    {
        Nothing,
        UsingEntrance,
        UsingLocalEntrance,
        UsingPortal,
        UsingWaypoint,
        PickingQuestItem,
        PickingNormalItem,
        EnteringHideout,
        Teleporting
    }
}