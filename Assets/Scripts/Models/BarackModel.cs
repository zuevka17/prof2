using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "BarackConfig")]
public class BarackModel : ScriptableObject
{
    public string Name;
    public float HealthPoitns;
    public BuildPriceModel BuildPrice;
    public string[] TrainingUnits;
}
