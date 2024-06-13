using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMapSize : MonoBehaviour
{
    [SerializeField] private GameObject _platform;
    // Start is called before the first frame update
    void Start()
    {
        int side = (int)Mathf.Sqrt(PlayerPrefs.GetInt("MapSize"));
        _platform.transform.localScale = new Vector3(side, 10, side);
    }
}
