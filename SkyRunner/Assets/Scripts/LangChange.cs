using Lean.Localization;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class LangChange : MonoBehaviour
{
    public Sprite[] _langSprites;
    public int langInt = 0;
    private Image _image;
    private string[] _languages = { "Rus", "Eng", "Ger", "Tur" };

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = _langSprites[YandexGame.savesData.usersLanguage];
    }

    public void ClickToChangeLanguage()
    {
        langInt++;
        if (langInt == 4) { langInt = 0; }
        YandexGame.savesData.usersLanguage = langInt;

        _image.sprite = _langSprites[langInt];
        LeanLocalization.SetCurrentLanguageAll(_languages[langInt]);
        YandexGame.SaveProgress();
    }
}
