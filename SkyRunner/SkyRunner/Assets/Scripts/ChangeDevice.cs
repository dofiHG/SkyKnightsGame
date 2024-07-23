using UnityEngine;
using UnityEngine.UI;
using YG;

public class ChangeDevice : MonoBehaviour
{
    public Sprite[] _sprites;

    private void Start() => gameObject.GetComponent<Image>().sprite = _sprites[YandexGame.savesData.device];

    public void ChangeDeviceF()
    {
        if (YandexGame.savesData.device == 0) { gameObject.GetComponent<Image>().sprite = _sprites[1]; YandexGame.savesData.device = 1; }
        else if (YandexGame.savesData.device == 1) { gameObject.GetComponent<Image>().sprite = _sprites[0]; YandexGame.savesData.device = 0; }
        YandexGame.SaveProgress();
    }
}
