using UnityEngine;
using YG;

public class PlaySceneSound : MonoBehaviour
{
    private void Start()
    {
        AudioListener.volume = YandexGame.savesData.IsPlaySound == 1 ? 1 : 0;
        Debug.Log(YandexGame.savesData.IsPlaySound);
    }
}
