using TMPro;
using UnityEngine;

public class PaddingTrollFaceCounter : MonoBehaviour
{
    private TMP_Text _counterText;
    public Transform _currentTransform;

    private void Start()
    {
        _counterText = GameObject.FindGameObjectWithTag("CounterTroll").GetComponent<TMP_Text>();
        _currentTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        switch(_counterText.text.Length)
        {
            case 1:
                _currentTransform.localPosition = new Vector3(-383, 298, 0); break;
            case 2:
                _currentTransform.localPosition = new Vector3(-333, 298, 0); break;
            case 3:
                _currentTransform.localPosition = new Vector3(-283, 298, 0); break;
            case 4:
                _currentTransform.localPosition = new Vector3(-243, 298, 0); break;
            case 5:
                _currentTransform.localPosition = new Vector3(-193, 298, 0); break;
            case 6:
                _currentTransform.localPosition = new Vector3(-163, 298, 0); break;
            case 7:
                _currentTransform.localPosition = new Vector3(-113, 298, 0); break;
        }
    }
}
