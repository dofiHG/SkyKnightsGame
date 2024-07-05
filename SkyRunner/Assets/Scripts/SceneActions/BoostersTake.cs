using UnityEngine;

public class BoostersTake : MonoBehaviour
{
    private CharacterStates _states;
    private AudioSource _audioSourceStar;
    private AudioSource _audioSourceBooster;

    private void Start()
    {
        _states = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStates>();
        _audioSourceStar = GameObject.Find("PickUpStar").GetComponent<AudioSource>();
        _audioSourceBooster = GameObject.Find("PickUpBooster").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (gameObject.name.Substring(0) == "Heart") { if (_states._hp + 1 <= 5) { _states._hp += 1; } _audioSourceBooster.Play(); }
            if (gameObject.name.Substring(0) == "Mana") { if (_states._mana + 2 <= 10) { _states._mana += 2; } else { _states._mana = 10; } _audioSourceBooster.Play(); }
            if (gameObject.name.Substring(0) == "Star") { _states._hasStarTaken = true; _audioSourceStar.Play(); }

            Destroy(gameObject);
        }
    }
}
