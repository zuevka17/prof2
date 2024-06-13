using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "BuilderConfig")]
public class BuilderModel : ScriptableObject
{
    public string Name;
    public float MoveSpeed;
    public float HealthPoitns;
    public TrainingPriceModel TrainingPrice;
    public float HarvestTime;
    public float RepairSpeed;
    public float RepairEfficiency;
}
