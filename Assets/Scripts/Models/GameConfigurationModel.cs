using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "GameConfiguration")]
public class GameConfigurationModel : ScriptableObject
{
    public DifficultyModel[] Difficulty;
    public float TownHallFreeFromResourceRadius;
    public float ResourceSpawnTime;
    public float ResourceSpawnAmount;
}
