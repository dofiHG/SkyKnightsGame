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
            if (YandexGame.savesData.activeLvls == YandexGame.savesData.currentLvl) { YandexGame.savesData.activeLvls += 1; }
            if (_player.GetComponent<CharacterStates>()._hasStarTaken) 
            { 
                if (YandexGame.savesData.currentLvl >= 3 && YandexGame.savesData.currentLvl < 10)
                    YandexGame.savesData.openedStars1[YandexGame.savesData.currentLvl - 3 ] = 1;
                if (YandexGame.savesData.currentLvl >= 11 && YandexGame.savesData.currentLvl < 20)
                    YandexGame.savesData.openedStars1[YandexGame.savesData.currentLvl - 4] = 1;
                if (YandexGame.savesData.currentLvl >= 21 && YandexGame.savesData.currentLvl < 30)
                    YandexGame.savesData.openedStars1[YandexGame.savesData.currentLvl - 5] = 1;
            }
            YandexGame.SaveProgress();
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
