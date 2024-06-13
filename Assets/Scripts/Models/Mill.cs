using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "MillConfig")]
public class MillModel : ScriptableObject
{
    public string Name;
    public float HealthPoitns;
    public BuildPriceModel BuildPrice;
    public string[] TrainingUnits;
}
