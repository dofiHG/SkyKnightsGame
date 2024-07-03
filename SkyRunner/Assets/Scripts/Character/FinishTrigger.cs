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
            PlayerPrefs.SetInt("activeLvLs", PlayerPrefs.GetInt("lvl")+1);
            if (_player.GetComponent<CharacterStates>()._hasStarTaken) { PlayerPrefs.SetInt($"Star{PlayerPrefs.GetInt("lvl")}", 1); }
            _player.GetComponent<CharacterMover>().enabled = false;
            _player.GetComponent<CharacterAttack>().enabled = false;
            gameObject.GetComponent<FinishMover>().enabled = true;
            if (!_player.GetComponentInChildren<AudioSource>().isPlaying) { _player.GetComponentInChildren<AudioSource>().Play(); }
            StartCoroutine(ShowFinishPanel());
        }
    }

    private IEnumerator ShowFinishPanel()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject.FindGameObjectWithTag("FinishPanel").GetComponent<Animator>().SetBool("Finish", true);
    }
}
