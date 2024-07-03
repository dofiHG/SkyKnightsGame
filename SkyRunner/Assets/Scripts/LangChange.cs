using Lean.Localization;
using UnityEngine;
using UnityEngine.UI;

public class LangChange : MonoBehaviour
{
    public Sprite[] _langSprites;
    public int langInt = 0;
    private Image _image;
    private string[] _languages = { "Rus", "Eng" };

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = _langSprites[langInt];
    }

    public void ClickToChangeLanguage()
    {
        langInt++;
        if (langInt == 2) { langInt = 0; }
        PlayerPrefs.SetInt("langInt", langInt);

        _image.sprite = _langSprites[langInt];
        LeanLocalization.SetCurrentLanguageAll(_languages[langInt]);
    }
}
