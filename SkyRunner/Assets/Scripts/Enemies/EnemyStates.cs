using System.Collections;
using UnityEngine;

public class EnemyStates : MonoBehaviour
{
    public int _hp;

    private Animator _animator;
    private CharacterMover _mover;

    [SerializeField] private int _mana;
    [SerializeField] private int _damage;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _mover = GameObject.FindWithTag("Player").GetComponent<CharacterMover>();
    }

    private void Update()
    {
        if (_hp <= 0) { Death(); }
    }

    private void Death()
    {
        _animator.SetBool("Death", true);
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        gameObject.GetComponent<StupidEnemiesMover>().enabled = false;
        StartCoroutine(WaitToDeath());
    }

    private IEnumerator WaitToDeath()
    {
        yield return new WaitForSeconds(0.4f);
        _mover._animator.SetBool("TakeDamage", false);
        Destroy(gameObject);
    }
}
