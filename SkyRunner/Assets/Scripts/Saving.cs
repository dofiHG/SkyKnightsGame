using UnityEngine;
using YG;

public class Saving : MonoBehaviour
{
    private TrollCounter _trollCounter;
    private Localization _localization;

    private void Start()
    {
        _localization = GameObject.FindGameObjectWithTag("LangBtn").GetComponent<Localization>();
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
        _trollCounter.trollPerClick = YandexGame.savesData.trollPerClick;
        _trollCounter.countTrollNow = YandexGame.savesData.countTrollNow;
        _trollCounter.trollPerSecond = YandexGame.savesData.trollPerSecond;
        _trollCounter.level = YandexGame.savesData.level;
        _localization.languageInt = YandexGame.savesData.langiageInt;
        Save();
    }

    public void Save()
    {
        YandexGame.savesData.trollPerClick = _trollCounter.trollPerClick;
        YandexGame.savesData.countTrollNow = _trollCounter.countTrollNow;
        YandexGame.savesData.trollPerSecond = _trollCounter.trollPerSecond;
        YandexGame.savesData.level = _trollCounter.level;
        YandexGame.savesData.langiageInt = _localization.languageInt;

        YandexGame.SaveProgress();
        Invoke("Save", 5);
    }

    public void Load() => YandexGame.LoadProgress();
}
