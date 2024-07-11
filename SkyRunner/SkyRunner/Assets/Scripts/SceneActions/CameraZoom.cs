using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name == "CameraZoom+") { Camera.main.orthographicSize = 7; }
        else { Camera.main.orthographicSize = 5; }
    }
}
