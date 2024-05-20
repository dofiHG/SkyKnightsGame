using UnityEngine;

public class ToBattle : MonoBehaviour
{
    public GameObject _startPanel;
    public GameObject _levelPanel;

    public void ClickToBattle()
    {
        _startPanel.SetActive(false);
        _levelPanel.SetActive(true);
    }

    public void ClickToCloseLVLPanel()
    {
        _startPanel.SetActive(true);
        _levelPanel.SetActive(false);
    }
}
