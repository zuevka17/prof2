using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _resolutionDropdown;
    [SerializeField] private Toggle _fullScreenToggle;
    [SerializeField] private Toggle _audioToggle;
    [SerializeField] private Slider _volumeSlider;

    [SerializeField] private GameObject _confirmWindow;
    [SerializeField] private GameObject _SettingsWindow;
    [SerializeField] private TMP_Text _exitText;

    private bool _isFullScreen = true;
    private string[] _res;

    private bool _isSettingsSaved = true;
    private bool _isFirstExit = true;

    private int _dropdownSelectedOption = 0;
    public void FullScreenMode()
    {
        _isFullScreen = !_isFullScreen;
    }
    
    public void ScreenRes()
    {
        _res = _resolutionDropdown.captionText.text.Split('x');
    }
    public void Audio()
    {

    }
    public void AudioValue()
    {

    }
    public void SetIsSavedToFalse()
    {
        _isSettingsSaved = false;
    }
    public void CheckIsSaved()
    {
        if(!_isSettingsSaved && _isFirstExit)
        {
            _confirmWindow.SetActive(true);
            _isFirstExit = false;
            _exitText.text = "—бросить";
        }
        else if(!_isFirstExit)
        {
            _fullScreenToggle.isOn = Screen.fullScreen;
            _resolutionDropdown.value = _dropdownSelectedOption;

            _exitText.text = "exit";
            _confirmWindow.SetActive(false);
            _SettingsWindow.SetActive(false);
        
            _isFirstExit = true;
            _isSettingsSaved = true;
        }
        else
        {
            _SettingsWindow.SetActive(false);
        }
    }
    public void SaveSettings()
    {
        Screen.SetResolution(int.Parse(_res[0]), int.Parse(_res[1]), Screen.fullScreen);
        Screen.fullScreen = _isFullScreen;

        _dropdownSelectedOption = _resolutionDropdown.value;

        _isSettingsSaved = true;
        _isFirstExit = true;

        _confirmWindow.SetActive(false);
        _SettingsWindow.SetActive(false);
        _exitText.text = "exit";    
    }
}
