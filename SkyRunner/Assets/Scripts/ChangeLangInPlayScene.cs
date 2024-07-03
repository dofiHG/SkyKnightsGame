using Lean.Localization;
using UnityEngine;

public class ChangeLangInPlayScene : MonoBehaviour
{
    private string[] _languages = { "Rus", "Eng" };

    private void Start() => LeanLocalization.SetCurrentLanguageAll(_languages[PlayerPrefs.GetInt("langInt")]);
}
