using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "GameSettings")]
public class ConfigurationModel : ScriptableObject
{
    public string Resolution;
    public bool FullScreenMode;
    public bool Audio;
    public float Volume;
}
