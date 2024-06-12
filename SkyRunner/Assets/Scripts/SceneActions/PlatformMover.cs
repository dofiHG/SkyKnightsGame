using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    [SerializeField] private float _leftBorder;
    [SerializeField ] private float _rightBorder;
    [SerializeField] private float _speed;

    private int _horiontalDirection = 1;

    private void Update()
    {
        if (transform.localPosition.x <= _leftBorder || transform.localPosition.x >= _rightBorder) { _horiontalDirection *= -1; }

        transform.Translate(_horiontalDirection * Time.deltaTime * _speed * Vector2.right);
    }
}
