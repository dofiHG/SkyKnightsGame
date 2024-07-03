using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public Sprite[] _sprites;
    private Image _image;
    private void Start() => _image = GetComponent<Image>();

    public void ChangeSound()
    {
        AudioListener.volume = AudioListener.volume == 1? 0 : 1;
        if (_image.sprite == _sprites[1]) { _image.sprite = _sprites[0]; }
        else { _image.sprite = _sprites[1]; }
    }
}
