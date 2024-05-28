using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Collider2D _collider;
    public float _reloadTime = 1;
    private CharacterStates _states;
    private int _damage = 1;
    private StupidEnemiesMover _enemyMover;
    
    public GameObject _player;
    private CharacterMover _mover;

    private void Start()
    {
        _enemyMover = GetComponent<StupidEnemiesMover>();
        _mover = GameObject.FindWithTag("Player").GetComponent<CharacterMover>();
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

    private void GiveDammage()
    {
        _states._hp -= _damage;
        _mover._rb.AddForce(new Vector2(3 * _enemyMover.direction, 3), ForceMode2D.Impulse);
        if (_states._hp >= 1)
        {
            _mover._animator.SetBool("TakeDamage", true);
            StartCoroutine(StopAnnimation());
        }
    }

    private IEnumerator StopAnnimation() 
    { 
        yield return new WaitForSeconds(0.35f);
        _mover._animator.SetBool("TakeDamage", false);
    }
}