using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class ToBattle : MonoBehaviour
{
    public GameObject _startPanel;
    public GameObject _levelPanel;

    private void Start()
    {
        AudioListener.volume = YandexGame.savesData.IsPlaySound == 1? 1 : 0;
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
