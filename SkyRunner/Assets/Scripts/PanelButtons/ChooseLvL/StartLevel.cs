using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    private int lvl;

    public void GoToLvL()
    {
        lvl = Convert.ToInt32(EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMP_Text>().text);
        PlayerPrefs.SetInt("lvl", lvl);
        SceneManager.LoadScene($"Level1");
    }
}
