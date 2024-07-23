using Lean.Localization;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class ToBattle : MonoBehaviour
{
    private string[] _languages = { "Rus", "Eng", "Ger", "Tur" };

    public GameObject _startPanel;
    public GameObject _levelPanel;

    private void Start()
    {
        AudioListener.volume = YandexGame.savesData.IsPlaySound == 1 ? 1 : 0;
        LeanLocalization.SetCurrentLanguageAll(_languages[YandexGame.savesData.usersLanguage]);
    }

    public void ClickToBattle()
    {
        _startPanel.SetActive(false);
        _levelPanel.SetActive(true);
    }

    public void ClickToCloseLVLPanel()
    {
        _startPanel.SetActive(true);
        _levelPanel.SetActive(false);
    }

    public void ClickToTutorial() => SceneManager.LoadScene("Tutorial");
}
