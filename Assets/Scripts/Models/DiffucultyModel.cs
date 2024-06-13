using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class DifficultyModel
{
    public float EnemySpawnTimer;
    public string[] EnemySpawnUnits;
    public float StartArmyLimit;
    public float ToMaxArmyAfterAttack;
}
