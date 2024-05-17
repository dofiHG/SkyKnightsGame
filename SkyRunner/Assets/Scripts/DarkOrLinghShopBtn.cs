using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DarkOrLinghShopBtn : MonoBehaviour
{
    private Button _button;
    private TrollCounter _trollCounter;
    public Image _image;
    public TMP_Text _caprion;
    public Image _troll;
    public TMP_Text _price;
    public TMP_Text _description;
    public TMP_Text _priceInt;

    private void Start()
    {
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
        _button = GetComponent<Button>();
    }

    private void Update()
    {
        if (_trollCounter.countTrollNow < Convert.ToInt64(_priceInt.text))
        {
            _button.image.color = new Color(0.8f, 0.8f, 0.8f);
            _image.color = new Color(0.8f, 0.8f, 0.8f);
            _caprion.color = new Color(0f, 0.4f, 0.5f);
            _troll.color = new Color(0.8f, 0.8f, 0.8f);
            _price.color = new Color(0.6f, 0.5f, 0.1f);
            _description.color = new Color(0.6f, 0.6f, 0.6f);
            _button.enabled = false;
        }

        else
        {
            _button.image.color = new Color(1f, 1f, 1f);
            _image.color = new Color(1f, 1f, 1f);
            _caprion.color = new Color(0f, 0.8f, 1f);
            _troll.color = new Color(1f, 1f, 1f);
            _price.color = new Color(1f, 0.75f, 0.1f);
            _description.color = new Color(1f, 1f, 1f);
            _button.enabled = true;
        }
    }
}
