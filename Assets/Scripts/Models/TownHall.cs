using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "TownHallConfig")]
public class TownHallModel : ScriptableObject
{
    public string Name;
    public float HealthPoitns;
    public BuildPriceModel BuildPrice;
    public float BuildRadius;
}
