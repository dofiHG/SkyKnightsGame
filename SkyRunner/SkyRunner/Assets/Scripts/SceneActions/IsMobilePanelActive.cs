using UnityEngine;
using YG;

public class IsMobilePanelActive : MonoBehaviour
{
    public GameObject _mobilePanel;

    private void Awake() => _mobilePanel.SetActive(YandexGame.savesData.device == 0? false: true);
}
