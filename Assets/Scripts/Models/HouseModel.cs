using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "HouseConfig")]
public class HouseModel : ScriptableObject
{
    public string Name;
    public float HealthPoitns;
    public BuildPriceModel TrainingPrice;
    public string[] TrainingUnits;
}
