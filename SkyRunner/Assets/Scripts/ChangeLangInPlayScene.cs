using Lean.Localization;
using UnityEngine;
using YG;

public class ChangeLangInPlayScene : MonoBehaviour
{
    private string[] _languages = { "Rus", "Eng", "Ger", "Tur" };

    private void Start()
    {
        LeanLocalization.SetCurrentLanguageAll(_languages[YandexGame.savesData.usersLanguage]);
        Debug.Log(YandexGame.savesData.usersLanguage);
    }
}
