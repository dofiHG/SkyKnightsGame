using UnityEngine;

public class Attack : MonoBehaviour
{
    private Collider2D _collider;
    public float _reloadTime = 1;
    private CharacterStates _states;
    private int _damage = 1;

    public GameObject _player;

    private void Start()
    {
        _collider = GetComponent<Collider2D>();
        _states = GameObject.FindWithTag("Player").GetComponent<CharacterStates>();
    }

    private void Update()
    {
        if (_collider.IsTouching(_player.GetComponent<Collider2D>()) && _reloadTime <= 0)
        {
            GiveDammage();
            _reloadTime = 1;
        }
        else { _reloadTime -= Time.deltaTime; }
    }

    private void GiveDammage() => _states._hp -= _damage;
}