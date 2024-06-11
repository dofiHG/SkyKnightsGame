using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StarActivator : MonoBehaviour
{
    private void Update()
    {
        Image[] star = GetComponentsInChildren<Image>();
        if (PlayerPrefs.GetInt($"Star{gameObject.GetComponentInChildren<TMP_Text>().text}") == 1) { star[1].color = new Color(255, 255, 255); }
    }
}
