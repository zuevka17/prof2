using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "SpearWarriorConfig")]
public class SpearWarriorModel : ScriptableObject
{
    public string Name;
    public float MoveSpeed;
    public float HealthPoitns;
    public BuildPriceModel TrainingPrice;
    public string[] TrainingUnits;
    public float MinAttackRange;
    public float MaxAttackRange;
    public float AttackDelay;
    public float Damage;
}
