using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "TempleConfig")]
public class TempleModel : ScriptableObject
{
    public string Name;
    public float HealthPoitns;
    public BuildPriceModel BuildPrice;
    public string[] TrainingUnits;
}
