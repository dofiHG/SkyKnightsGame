using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    public void GoToLvL()
    {
        int lvl = Int32.Parse(GetComponentInChildren<TMP_Text>().text);
        SceneManager.LoadScene($"Level{lvl}");
    }
}
