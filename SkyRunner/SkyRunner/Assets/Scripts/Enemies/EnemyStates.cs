using System.Collections;
using UnityEngine;

public class EnemyStates : MonoBehaviour
{
    public int _hp;
    public int _damage;
    
    int check = 0;
    private Animator _animator;
    private CharacterMover _mover;
    private float _timmer;

    [SerializeField] private int _mana;
    

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

        if( check == 0) { gameObject.transform.position = new Vector2(transform.position.x, transform.position.y); check = 1; }

        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

        try { gameObject.GetComponent<StupidEnemiesMover>().enabled = false; }
        catch { gameObject.GetComponent<CleverEnemyMover>().enabled = false; }
        _timmer = gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;
        StartCoroutine(WaitToDeath());
    }

    private IEnumerator WaitToDeath()
    {
        yield return new WaitForSeconds(_timmer);
        _mover._animator.SetBool("TakeDamage", false);
        Destroy(gameObject);
    }

    public void StopAnimationDamage() { gameObject.GetComponent<Animator>().SetBool("Damage", false); }
}
