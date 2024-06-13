using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "SmelterConfig")]
public class SmelterModel : ScriptableObject
{
    public string Name;
    public float HealthPoitns;
    public BuildPriceModel TrainingPrice;
    public string[] TrainingUnits;
}
