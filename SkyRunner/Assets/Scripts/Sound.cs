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
    }

    public void ChangeSound()
    {
        AudioListener.volume = AudioListener.volume == 1? 0 : 1;
        if (_image.sprite == _sprites[1]) { _image.sprite = _sprites[0]; YandexGame.savesData.IsPlaySound = 1; }
        else { _image.sprite = _sprites[1]; YandexGame.savesData.IsPlaySound = 0; }
    }
}
