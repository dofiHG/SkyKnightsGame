using UnityEngine;

public class FinishMover : MonoBehaviour
{
    private GameObject _player;

    private void Start() =>  _player = GameObject.FindGameObjectWithTag("Player");

    private void Update() => BlockMove();

    private void BlockMove() => _player.transform.Translate(2 * Time.deltaTime * Vector2.right);
}
