﻿using UnityEngine;

public class Config
{
    // IO
    public const float MOUSE_SENSITIVE = 2f;

    // Interaction
    public const float INTERACTION_RANGE = 8f;

    // Color
    public static Color32 INTERACTION_COLOR_DEFAULT = new Color32(255, 255, 255, 255);
    public static Color32 INTERACTION_COLOR_SELECTED = new Color32(0, 200, 0, 255);
    public static Color32 MISSION_COLOR_UNLOCKED = new Color32(136, 255, 120, 255);
    public static Color32 MISSION_COLOR_ONGOING = new Color32(255, 230, 111, 255);
    public static Color32 MISSION_COLOR_COMPLETED = new Color32(17, 142, 0, 255);
    public static Color32 MISSION_COLOR_FAILED = new Color32(176, 33, 33, 255);

    // Layer Index
    public const int LAYER_INDEX_INTERACTABLE = 8;

    // Modifier
    public const float MODIFIER_TIMER = 1f;

    // Time
    public const float TIME_ONEDAY = 360f;
    public const float TIME_DAY_UPDATE_DELAY = 1f;
    public const float TIME_DAY_TRANSITION_OFFSET = -25f;
    public const float TIME_ANIMATION_TRANSITION_FRAME = 0.02f;
    public const float TIME_ANIMATION_TRANSITION_DELAY = 1f;
    public const float TIME_ANIMATION_TRANSCAM = 5f;

    // Default Setting
    public const float DEFAULT_INTI_FOOD = 10;
    public const float DEFAULT_INTI_WATER = 5;
    public const float DEFAULT_INTI_FUND = 1000;
    public const float DEFAULT_INTI_TROOP = 200;
    public const float DEFAULT_GROWTH_FOOD = 10;
    public const float DEFAULT_GROWTH_WATER = 5;
    public const float DEFAULT_GROWTH_FUND = 500;
    public const float DEFAULT_GROWTH_TROOP = 100;
}
