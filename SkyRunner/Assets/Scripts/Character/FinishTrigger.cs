using System.Collections;
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
            if (!_player.GetComponentInChildren<AudioSource>().isPlaying) { _player.GetComponentInChildren<AudioSource>().Play(); }
            StartCoroutine(OffSound());
        }
    }

    private IEnumerator OffSound()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject.FindGameObjectWithTag("FinishPanel").GetComponent<Animator>().SetBool("Finish", true);
    }
}
