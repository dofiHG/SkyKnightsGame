using System.Collections;
using TMPro;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    private int i = 0;

    public GameObject _panel;
    public string[] _messages;
    public TMP_Text _currentText;

    public void WriteText()
    {
        _currentText.text = "";
        StartCoroutine(TextAnimation());
    }

    public IEnumerator TextAnimation()
    {
        i++;
        foreach (var letter in _messages[i])
        {
            _currentText.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void ButtonOkCkick()
    {
         _panel.SetActive(false);
    }
}
