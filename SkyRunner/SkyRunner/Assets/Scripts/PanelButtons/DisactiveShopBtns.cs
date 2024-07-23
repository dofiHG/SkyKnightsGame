using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class DisactiveShopBtns : MonoBehaviour
{
    public TMP_Text _openNextLvlTxt;
    public Button _openNextLvlBtn;
    public TMP_Text _starAdviceTxt;
    public Button _starAdviceBtn;
    public TMP_Text _openStarTxt;
    public Button _openStarBtn;

    private void OnEnable()
    {
        if (YandexGame.savesData.activeLvls == 30) { _openNextLvlTxt.gameObject.SetActive(false); _openNextLvlBtn.gameObject.SetActive(false); }
        
        for (int i = 0; i < YandexGame.savesData.openedStars1.Length; i++)
        {
            if (YandexGame.savesData.openedStars1[i] == 0) { return; }
        }

        _starAdviceTxt.gameObject.SetActive(false);
        _starAdviceBtn.gameObject.SetActive(false);
        _openStarBtn.gameObject.SetActive(false);
        _openStarTxt.gameObject.SetActive(false);

    }
}
