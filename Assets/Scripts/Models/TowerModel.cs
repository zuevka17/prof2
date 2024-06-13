using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "TowerConfig")]
public class TowerModel : ScriptableObject
{
    public string Name;
    public float HealthPoitns;
    public BuildPriceModel BuildPrice;
    public float DetectRadius;
    public float BuildRadius;
    public float ArcherCapacity;
    public float MinAttackDistance;
    public float MaxAttackDistance;
    public float DamagePerArcher;
}
