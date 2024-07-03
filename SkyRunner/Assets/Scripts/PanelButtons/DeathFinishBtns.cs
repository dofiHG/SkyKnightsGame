using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFinishBtns : MonoBehaviour
{
    public void ToMenu() => SceneManager.LoadScene("MainMenu");

    public void PlusHpWithAd() => Debug.Log(0);

    public void TryAgain() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    public void Continue()
    {
        PlayerPrefs.SetInt("lvl", PlayerPrefs.GetInt("lvl") + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        LevelActivator acrivator = GameObject.FindGameObjectWithTag("1").GetComponent<LevelActivator>();

        int levelNumberActivate = PlayerPrefs.GetInt("lvl");
        acrivator._levelNumber[levelNumberActivate - 1].SetActive(true);
        acrivator._levelNumber[levelNumberActivate - 2].SetActive(false);
    }
}
