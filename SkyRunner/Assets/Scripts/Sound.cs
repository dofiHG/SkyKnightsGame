using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class Sound : MonoBehaviour
{
    public Sprite[] _sprites;
    private Image _image;
    private void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = YandexGame.savesData.IsPlaySound == 1? _sprites[0] : _sprites[1];
        AudioListener.volume = YandexGame.savesData.IsPlaySound == 1? 1 : 0;
    }

    public void ChangeSound()
    {
        if (_image.sprite == _sprites[1]) { _image.sprite = _sprites[0]; YandexGame.savesData.IsPlaySound = 1; AudioListener.volume = 1; }
        else { _image.sprite = _sprites[1]; YandexGame.savesData.IsPlaySound = 0; AudioListener.volume = 0; }
        YandexGame.SaveProgress();
    }
}
