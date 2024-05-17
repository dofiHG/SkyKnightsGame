using UnityEngine;
using UnityEngine.UI;
using YG;

public class Advertising : MonoBehaviour
{
    private TrollCounter _trollCounter;
    private float _advetrisingTimmer = 60f;
    private Button _advetrisingButton;

    private void Start()
    {
        _advetrisingButton = GameObject.FindGameObjectWithTag("AdBtn").GetComponent<Button>();
        _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();
    }

    private void Update()
    {
        _advetrisingTimmer += Time.deltaTime;
        if(_advetrisingTimmer > 60f)
        {
            _advetrisingButton.gameObject.SetActive(true);
        }
    }

    private void Del()
    {
        if (_trollCounter.trollPerClick % 2 != 0) { _trollCounter.trollPerClick += 1; }
        _trollCounter.trollPerClick /= 2;
    }

    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    void Rewarded(int id)
    {
        _trollCounter.trollPerClick *= 2;
        _advetrisingButton.gameObject.SetActive(false);
        _advetrisingTimmer = 0;
        Invoke("Del", 60);
    }
}
