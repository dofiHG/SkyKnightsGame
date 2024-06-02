using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFinishBtns : MonoBehaviour
{
    public void ToMenu() => SceneManager.LoadScene("MainMenu");

    public void PlusHpWithAd() => Debug.Log(0);

    public void TryAgain() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
