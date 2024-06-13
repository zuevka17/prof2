using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _enemyNumberDropdown;
    [SerializeField] private TMP_Dropdown _difficultyDropdown;
    [SerializeField] private TMP_InputField _playerName;
    [SerializeField] private TMP_InputField _mapSize;

    [SerializeField] private TMP_InputField[] _enemiesInputFields;
    [SerializeField] private Button[] _enemiesButtons;

    [SerializeField] private Button _playerColorButton;

    private List<Color> _availableColors;
    private List<Color> _takenColors;

    private bool _isCanStartGame;

    private void Start()
    {
        _availableColors = new List<Color> { Color.gray, Color.red, Color.blue, Color.green, Color.white, Color.yellow, Color.cyan };
        _takenColors = new List<Color>();
    }
    private void Update()
    {
        CheckEnemyNames();
    }
    public void ChangePlayerColor()
    {
        CheckTakenColors();
        List<Color> possibleCollors = _availableColors.Except(_takenColors).ToList();
        _playerColorButton.image.color = possibleCollors[Random.Range(0, possibleCollors.Count)];
    }
    public void ChangeEnemyColor(int enemyNumber)
    {
        CheckTakenColors();
        List<Color> possibleCollors = _availableColors.Except(_takenColors).ToList();
        switch (enemyNumber)
        {
            case 1:
                _enemiesButtons[0].image.color = possibleCollors[Random.Range(0, possibleCollors.Count)];
                break;
            case 2:
                _enemiesButtons[1].image.color = possibleCollors[Random.Range(0, possibleCollors.Count)];
                break;
            case 3:
                _enemiesButtons[2].image.color = possibleCollors[Random.Range(0, possibleCollors.Count)];
                break;
            case 4:
                _enemiesButtons[3].image.color = possibleCollors[Random.Range(0, possibleCollors.Count)];
                break;
            case 5:
                _enemiesButtons[4].image.color = possibleCollors[Random.Range(0, possibleCollors.Count)];
                break;
        }
    }
    private void CheckTakenColors()
    {
        _takenColors = new List<Color> { _playerColorButton.image.color, _enemiesButtons[0].image.color, _enemiesButtons[1].image.color,
            _enemiesButtons[2].image.color, _enemiesButtons[3].image.color, _enemiesButtons[4].image.color};
    }
    public void SetEnemyNumber()
    {
        DisableAllEnemies();
        //tyt for a ne switch
        for(int i = 0; i < int.Parse(_enemyNumberDropdown.captionText.text); i++)
        {
            _enemiesInputFields[i].gameObject.SetActive(true);
            _enemiesButtons[i].gameObject.SetActive(true);

        }
    }
    private void DisableAllEnemies()
    {
        foreach (var item in _enemiesInputFields)
        {
            item.gameObject.SetActive(false);
        }
        foreach (var item in _enemiesButtons)
        {
            item.gameObject.SetActive(false);
        }
    }
    private void CheckEnemyNames()
    {
        var duplicates = _enemiesInputFields
            .GroupBy(field => field.text)
            .Where(group => group.Count() > 1)
            .SelectMany(group => group)
            .ToList();
        var notDublictates = _enemiesInputFields
            .GroupBy(field => field.text)
            .Where(group => group.Count() <= 1)
            .SelectMany(group => group)
            .ToList();

        foreach (var i in duplicates)
        {
            i.textComponent.color = Color.red;
        }
        foreach (var i in notDublictates)
        {
            i.textComponent.color = Color.white;
        }
        if (duplicates.Count != 0)
        {
            _isCanStartGame = false;
        }
        else
        {
            _isCanStartGame = true;
        }
    }
    public void StartGame()
    {
        if (int.Parse(_mapSize.text) < 2500 || int.Parse(_mapSize.text) > 10000 || !_isCanStartGame)
        {
            return;
        }

        PlayerPrefs.SetInt("EnemyNumber", int.Parse(_enemyNumberDropdown.captionText.text));
        PlayerPrefs.SetString("Difficulty", _difficultyDropdown.captionText.text);
        PlayerPrefs.SetString("PlayerName", _playerName.text);
        PlayerPrefs.SetString("PlayerColor", JsonUtility.ToJson(_playerColorButton.image.color));
        PlayerPrefs.SetInt("MapSize", int.Parse(_mapSize.text));

        string enemySettings = string.Empty;

        for(int i = 0; i < int.Parse(_enemyNumberDropdown.captionText.text); i++)
         {
           enemySettings += $"{_enemiesInputFields[i].text}+{JsonUtility.ToJson(_enemiesButtons[i].image.color)}|";
        }

        PlayerPrefs.SetString("EnemySettings", enemySettings);
        Debug.Log(enemySettings);

        SceneManager.LoadScene(1);
    }
}
