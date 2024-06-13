using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "SiedgeTowerConfig")]
public class SiedgeTowerModel : ScriptableObject
{
    public string Name;
    public float MoveSpeed;
    public float HealthPoitns;
    public TrainingPriceModel TrainingPrice;
    public string[] TrainingUnits;
    public float MaxAttackRange;
    public float MinAttackRange;
    public float AttackDelay;
    public float DamagePerArcher;
    public float UnitCapacity;

}
