using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GenerateBases : MonoBehaviour
{
    [SerializeField] private GameObject _platform;
    [SerializeField] private GameObject _basePrefab;
    private Vector3 _platformMin;
    private Vector3 _platformMax;
    private void Start()
    {
        var collider = _platform.GetComponent<Collider>();

        _platformMin = collider.bounds.min + new Vector3(3, 0, 3);
        _platformMax = collider.bounds.max - new Vector3(3, 0, 3); ;

        GeneratePlayerBase();
        GenerateEnemyBases();
    }
    private void GeneratePlayerBase()
    {
        var spawnPoint = new Vector3(Random.Range(_platformMin.x,_platformMax.x),
            _platformMax.y + 0.2f,
            Random.Range(_platformMin.z, _platformMax.z));
        var playerBase = Instantiate(_basePrefab, spawnPoint, new Quaternion(0f,180f,0f,0f));
        playerBase.gameObject.tag = "PlayerBase";

        var tmp = playerBase.GetComponentInChildren<TMP_Text>();
        tmp.text = PlayerPrefs.GetString("PlayerName");
        tmp.color = JsonUtility.FromJson<Color>(PlayerPrefs.GetString("PlayerColor"));
    }
    private void GenerateEnemyBases()
    {
        PlayerPrefs.GetString("EnemySettings");

        List<string[]> enemySettings = new List<string[]>();
        string[] enemies = PlayerPrefs.GetString("EnemySettings").Split('|');

        foreach (string s in enemies)
        {
            enemySettings.Add(s.Split('+'));
        }
        enemySettings.RemoveAt(enemySettings.Count - 1);

        foreach(var enemy in enemySettings)
        {
            var spawnPoint = new Vector3(Random.Range(_platformMin.x, _platformMax.x),
            _platformMax.y + 0.2f,
            Random.Range(_platformMin.z, _platformMax.z));
            var enemyBase = Instantiate(_basePrefab, spawnPoint, new Quaternion(0f, 180f, 0f, 0f));
            enemyBase.gameObject.tag = "EnemyBase";

            var tmp = enemyBase.GetComponentInChildren<TMP_Text>();
            tmp.text = enemy[0];
            tmp.color = JsonUtility.FromJson<Color>(enemy[1]);
        }
    }
}
