using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "HeavyWarriorConfig")]
public class HeavyWarriorModel : ScriptableObject
{
    public string Name;
    public float MoveSpeed;
    public float HealthPoitns;
    public TrainingPriceModel TrainingPrice;
    public float MinAttackRange;
    public float MaxAttackRange;
    public float AttackDelay;
    public float Damage;
}
