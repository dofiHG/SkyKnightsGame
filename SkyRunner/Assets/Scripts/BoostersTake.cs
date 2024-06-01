using UnityEngine;

public class BoostersTake : MonoBehaviour
{
    private CharacterStates _states;

    private void Start()
    {
        _states = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStates>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if(gameObject.name == "Heart") { if (_states._hp + 1 <= 5) { _states._hp += 1; } }
            if(gameObject.name == "Mana") { if (_states._mana + 2 <= 10) { _states._mana += 2; } else { _states._mana = 10; } }

            Destroy(gameObject);
        }
    }
}
