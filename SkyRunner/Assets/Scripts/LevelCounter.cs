using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour
{
    private double _levelAmount;
    private TrollCounter _trollCounter;
    private Slider _slider;

    public Button _button;
    public TMP_Text _levelText;
    public TMP_Text _levelInt;

    private void Start() 
    {
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        switch (_trollCounter.level)
        {
            case 1: _levelAmount = 170; break;
            case 2: _levelAmount = 1800; break;
            case 3: _levelAmount = 5500; break;
            case 4: _levelAmount = 55500; break;
            case 5: _levelAmount = 500500; break;
            case 6: _levelAmount = 50000000; break;
            case 7: _levelAmount = 5000050000; break;
            case 8: _levelAmount = 50000000000; break;
            case 9: _levelAmount = 500000000000; break;
            case 10: _levelAmount = 50000000000000; break;
            case 11: _levelAmount = 500000000000000; break;
            case 12: _levelAmount = 5000000000000000; break;
            case 13: _levelAmount = 50000000000000000; break;
            case 14: _levelAmount = 900000000000000000; break;
            case 15: _levelAmount = 9999999999999999999; break;
        }

        if (_trollCounter.countTrollNow > _levelAmount) { _trollCounter.level++; }
        _slider.value = _trollCounter.countTrollNow;
        _levelInt.text = _trollCounter.level.ToString();
        if (_trollCounter.level > 14 && _trollCounter.countTrollNow > _levelAmount) { _levelAmount *= 2; }

        _slider.maxValue = (float)_levelAmount;
    }
}
