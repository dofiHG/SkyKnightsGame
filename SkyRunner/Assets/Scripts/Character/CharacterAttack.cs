using System.Collections;
using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
    [SerializeField] private float _reloadTime;

    private CharacterStates _states;
    private Collider2D _collider;

    public Transform _attackPosition;
    public LayerMask _enemy;
    public float _attackRange;
    public GameObject _dialoguePanel;
    public GameObject _fireballPrefab;

    private void Start()
    {
        _states = GetComponent<CharacterStates>();
        _collider = gameObject.GetComponent<Collider2D>();
    }

    private void Update()
    {
        bool universalCheckForAttack = gameObject.GetComponent<Animator>().GetBool("IsJumping") == false && !_dialoguePanel.activeInHierarchy;
        
        if (_reloadTime <= 0)
        {
            if (Input.GetMouseButton(0) && universalCheckForAttack)
                DefaultAttack();

            if (Input.GetMouseButton(0) && universalCheckForAttack && Input.GetKey(KeyCode.Q) && gameObject.GetComponent<CharacterStates>()._mana >= 2)
                FireBallAttack();

            if (gameObject.GetComponent<Animator>().GetBool("IsJumping") == true && !_dialoguePanel.activeInHierarchy && Input.GetMouseButton(0) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
                JumpAttack();
         }
        else { _reloadTime -= Time.deltaTime; }
    }

    private void DefaultAttack()
    {
        _reloadTime = 1;
        gameObject.GetComponent<Animator>().SetInteger("Attack", 1);
        Collider2D[] enemies = Physics2D.OverlapCircleAll(_attackPosition.position, _attackRange, _enemy);

        for (int i = 0; i < enemies.Length; i++)
        {
            try { enemies[i].GetComponent<Animator>().SetBool("Damage", true); }
            finally { enemies[i].GetComponent<EnemyStates>()._hp -= _states._damage; }
        }
    }

    private void FireBallAttack()
    {
        _reloadTime = 1;
        _states._mana -= 2;
        if (gameObject.GetComponent<SpriteRenderer>().flipX == false)
        {
            _fireballPrefab.GetComponent<SpriteRenderer>().flipX = false;
            Instantiate(_fireballPrefab, new Vector2(gameObject.transform.position.x + 1.3f, gameObject.transform.position.y + 0.6f), Quaternion.identity);
        }
        else
        {
            _fireballPrefab.GetComponent<SpriteRenderer>().flipX = true;
            Instantiate(_fireballPrefab, new Vector2(gameObject.transform.position.x - 1.3f, gameObject.transform.position.y + 0.6f), Quaternion.identity);
        }
    }

    private void JumpAttack()
    {
        _reloadTime = 1;
        gameObject.GetComponent<Animator>().SetInteger("Attack", 2);
        _collider.isTrigger = true;
        float xOffset = gameObject.GetComponent<CharacterMover>()._horizontalDirection > 0 ? 0.24f : -0.24f;
        _collider.offset = new Vector2(xOffset, _collider.offset.y/2);
    }

    public void StopAttackAnimations()
    {
        gameObject.GetComponent<Animator>().SetInteger("Attack", 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy") 
        { 
            try { collision.gameObject.GetComponent<Animator>().SetBool("Damage", true); }
            finally { collision.gameObject.GetComponent<EnemyStates>()._hp -= 3; }
            int dir = gameObject.transform.position.x > collision.transform.position.x ? -3 : 3;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(dir, 0), ForceMode2D.Impulse);
        }
    }
}