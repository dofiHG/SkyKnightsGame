using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class DeathFinishBtns : MonoBehaviour
{
    public void ToMenu() => SceneManager.LoadScene("MainMenu");

    public void TryAgain()
    {
        Debug.Log(gameObject.name + "123");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Continue()
    {
        if (YandexGame.savesData.currentLvl < 30)
        {
            YandexGame.savesData.currentLvl += 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else { ToMenu(); }
    }
}
