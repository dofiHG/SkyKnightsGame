using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private Transform _charactersPosition;

    public float _start;
    public float _end;

    private void Start() => _charactersPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    private void Update()
    {
        if (_charactersPosition.position.x > _start && _charactersPosition.position.x < _end)
            transform.position = new Vector3(_charactersPosition.transform.position.x, transform.position.y, -10);

        if (_charactersPosition.position.y != transform.position.y)
            transform.position = new Vector3(transform.position.x, _charactersPosition.position.y + 2, -10);
    }
}