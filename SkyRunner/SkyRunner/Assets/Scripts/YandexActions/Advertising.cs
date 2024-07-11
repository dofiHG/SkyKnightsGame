using UnityEngine;
using YG;

public class Advertising : MonoBehaviour
{
    private CharacterStates _player;
    private void Start() => _player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStates>();

    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    void Rewarded(int id)
    {
        if (_player._hp >= 0 && _player._hp < 5) 
        {
            _player.transform.position =  _player.GetComponent<SaveSafePosition>()._currentPostion;
            _player._hp += 1;
            Debug.Log(_player.transform.position);
        }
        if (_player._hp < 0) 
        {
            _player.transform.position = _player.GetComponent<SaveSafePosition>()._currentPostion;
            _player._hp = 1; 
        }
        else { _player._hp = 5; }
        YandexGame.savesData.isPlusHp = true;
    }
}
