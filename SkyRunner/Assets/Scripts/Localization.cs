using Lean.Localization;
using UnityEngine;
using UnityEngine.UI;

public class Localization : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites;
    public int languageInt = 0;
    private string[] languages = { "Russain", "English", "Turkish", "German"};
    private Image _sprite;

    private void Start()
    {
        _sprite = GetComponent<Image>();
        _sprite.sprite = _sprites[languageInt];
    }

    public void ClickToChangeLanguage()
    {
        languageInt++;
        if (languageInt == 4) { languageInt = 0; }

        _sprite.sprite = _sprites[languageInt];

        LeanLocalization.SetCurrentLanguageAll(languages[languageInt]);
    }
}
