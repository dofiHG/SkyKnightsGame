using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class StarActivator : MonoBehaviour
{
    private void Start()
    {
        TMP_Text lvlNumber = GetComponentInChildren<TMP_Text>();
        Image[] star = GetComponentsInChildren<Image>();

        if (YandexGame.savesData.openedStars[Convert.ToInt32(lvlNumber.text) - 3] == 1) { star[1].color = new Color(255, 255, 255); }
    }
}
