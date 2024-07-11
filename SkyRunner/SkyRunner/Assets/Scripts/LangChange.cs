using Lean.Localization;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class LangChange : MonoBehaviour
{
    public Sprite[] _langSprites;
    private Image _image;
    private string[] _languages = { "Rus", "Eng", "Ger", "Tur" };

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = _langSprites[YandexGame.savesData.usersLanguage];
    }

    public void ClickToChangeLanguage()
    {
        YandexGame.savesData.usersLanguage++;
        if (YandexGame.savesData.usersLanguage == 4) { YandexGame.savesData.usersLanguage = 0; }

        _image.sprite = _langSprites[YandexGame.savesData.usersLanguage];
        LeanLocalization.SetCurrentLanguageAll(_languages[YandexGame.savesData.usersLanguage]);
        YandexGame.SaveProgress();
    }
}
