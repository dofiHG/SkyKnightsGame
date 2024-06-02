using System.Collections;
using UnityEngine;

public class FinishMover : MonoBehaviour
{
    private GameObject _player;

    private void Start() =>  _player = GameObject.FindGameObjectWithTag("Player");

    private void Update() => BlockMove();

    private void BlockMove()
    {
        _player.transform.Translate(2 * Time.deltaTime * Vector2.right);
        _player.GetComponent<Animator>().SetBool("IsRunning", true);
        _player.GetComponent<Animator>().SetBool("IsJumping", false);
        _player.GetComponent<Animator>().SetBool("JumpAttack", false);
        _player.GetComponent<Animator>().SetInteger("Attack", 0);
    }
}
