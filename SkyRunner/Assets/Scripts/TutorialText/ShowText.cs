using TMPro;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    private int i = 0;

    public string[] _messages;
    public TMP_Text _currentText;
    public GameObject _nextTextTrigger;

    public void WriteDialogueText()
    {
        foreach (char letter in _messages[i]) 
        { 
            _currentText.text += letter;
            //yield return new WaitForSeconds(0.05f);
        }
        i++;
    }
}
