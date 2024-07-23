using UnityEngine;

public class TriggerText : MonoBehaviour
{
    private ShowText _textPanel;

    public GameObject _panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            _panel.SetActive(true);
            _textPanel = GameObject.FindGameObjectWithTag("TextPanel").GetComponent<ShowText>();
            _textPanel.WriteText();
            Destroy(gameObject);
        }
        
    }
}
