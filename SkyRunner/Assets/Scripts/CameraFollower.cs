using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private Transform _charactersPosition;

    public float _start;
    public float _end;

    private void Start() => _charactersPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    private void Update()
    {
        if (transform.position.x - _start > _start)
        {
            transform.position = new Vector3(_charactersPosition.transform.position.x + 8.67f, transform.position.y, transform.position.z);
        }
    }
}
