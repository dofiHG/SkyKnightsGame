using UnityEngine;

public class TriggerText : MonoBehaviour
{
    private ShowText _textPanel;

    private void Start()
    {
        _textPanel = GameObject.FindGameObjectWithTag("TextPanel").GetComponent<ShowText>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _textPanel.WriteDialogueText();
        Destroy(gameObject);
    }
}
