using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class StartLevel : MonoBehaviour
{
    private static int lvl;

    public void GoToLvL()
    {
        if (EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color != new Color(255, 255, 255)) { }
        else
        {
            lvl = Convert.ToInt32(EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMP_Text>().text);
            YandexGame.savesData.currentLvl = lvl;
            SceneManager.LoadScene($"Level1");
        }
    }
}
