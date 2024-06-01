using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            _player.GetComponent<CharacterMover>().enabled = false;
            _player.GetComponent<CharacterAttack>().enabled = false;
            gameObject.GetComponent<FinishMover>().enabled = true;
        }
    }
}
