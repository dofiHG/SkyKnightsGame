using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Collider2D _collider;
    private float _reloadTime = 1;
    private CharacterStates _states;
    private CharacterMover _mover;
    
    public GameObject _player;
    public AudioSource _punch;

    private void Start()
    {
        _punch = GameObject.Find("Punch").GetComponent<AudioSource>();
        _mover = GameObject.FindWithTag("Player").GetComponent<CharacterMover>();
        _collider = GetComponent<Collider2D>();
        _states = GameObject.FindWithTag("Player").GetComponent<CharacterStates>();
        _player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        if (_collider.IsTouching(_player.GetComponent<Collider2D>()) && _reloadTime <= 0)
        {
            GiveDammage();
        }
        else { _reloadTime -= Time.deltaTime; }
    }

    private void GiveDammage()
    {
        _punch.Play();
        _reloadTime = 1;
        _states._hp -= gameObject.GetComponent<EnemyStates>()._damage;

        if(transform.position.x >= _player.GetComponent<Transform>().position.x) { _mover._rb.AddForce(new Vector2(-5, 0), ForceMode2D.Impulse); }
        else { _mover._rb.AddForce(new Vector2(5, 0), ForceMode2D.Impulse); }

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