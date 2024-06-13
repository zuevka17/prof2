using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "HealerConfig")]
public class HealerModel : ScriptableObject
{
    public string Name;
    public float MoveSpeed;
    public float HealthPoitns;
    public TrainingPriceModel TrainingPrice;
    public float MinHealRange;
    public float MaxHealRange;
    public float HealDelay;
    public float HealAmount;
}
