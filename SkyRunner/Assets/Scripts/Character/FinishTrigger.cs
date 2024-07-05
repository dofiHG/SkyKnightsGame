using System.Collections;
using UnityEngine;
using YG;

public class FinishTrigger : MonoBehaviour
{
    private GameObject _player;
    private AudioSource _audioSourceFinish;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _audioSourceFinish = GameObject.Find("WinSound").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            _audioSourceFinish.Play();
            if (YandexGame.savesData.activeLvls == YandexGame.savesData.currentLvl) { YandexGame.savesData.activeLvls = YandexGame.savesData.activeLvls + 1; }
            if (_player.GetComponent<CharacterStates>()._hasStarTaken) { YandexGame.savesData.openedStars[YandexGame.savesData.currentLvl - 3] = 1; }
            YandexGame.SaveProgress();
            _player.GetComponent<CharacterMover>().enabled = false;
            _player.GetComponent<CharacterAttack>().enabled = false;
            gameObject.GetComponent<FinishMover>().enabled = true;
            if (!_player.GetComponentInChildren<AudioSource>().isPlaying) { _player.GetComponentInChildren<AudioSource>().Play(); }
            StartCoroutine(ShowFinishPanel());
            YandexGame.savesData.activeLvls = 1;
            YandexGame.savesData.IsPlaySound = 1;
            YandexGame.SaveProgress();
        }
    }

    private IEnumerator ShowFinishPanel()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject.FindGameObjectWithTag("FinishPanel").GetComponent<Animator>().SetBool("Finish", true);
    }
}
