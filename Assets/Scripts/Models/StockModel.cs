using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "StockConfig")]
public class StockModel : ScriptableObject
{
    public string Name;
    public float HealthPoitns;
    public BuildPriceModel TrainingPrice;
    public int ToMaxResources;
}
