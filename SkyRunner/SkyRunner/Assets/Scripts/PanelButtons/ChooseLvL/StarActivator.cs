using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class StarActivator : MonoBehaviour
{
    private void OnEnable()
    {
        TMP_Text lvlNumber = GetComponentInChildren<TMP_Text>();
        Image[] star = GetComponentsInChildren<Image>();

        if (Convert.ToInt32(lvlNumber.text) >= 3 && Convert.ToInt32(lvlNumber.text) < 10 && YandexGame.savesData.openedStars1[Convert.ToInt32(lvlNumber.text) - 3] == 1)
            { star[1].color = new Color(255, 255, 255); }
        if (Convert.ToInt32(lvlNumber.text) >= 11 && Convert.ToInt32(lvlNumber.text) < 20 && YandexGame.savesData.openedStars1[Convert.ToInt32(lvlNumber.text) - 4] == 1)
            { star[1].color = new Color(255, 255, 255); }
        if (Convert.ToInt32(lvlNumber.text) >= 21 && Convert.ToInt32(lvlNumber.text) < 30 && YandexGame.savesData.openedStars1[Convert.ToInt32(lvlNumber.text) - 5] == 1)
            { star[1].color = new Color(255, 255, 255); }
    }
}
