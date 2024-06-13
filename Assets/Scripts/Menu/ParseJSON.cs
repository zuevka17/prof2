using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParseJSON : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] models;
    private void Start()
    {
        var jsonFiles = Resources.LoadAll<TextAsset>("Data");
        for (int i = 0; i < jsonFiles.Length - 1; i++)
            JsonUtility.FromJsonOverwrite(jsonFiles[i].text, models[i]);
    }
}
