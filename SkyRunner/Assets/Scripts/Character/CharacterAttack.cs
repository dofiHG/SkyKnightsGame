using System.Collections;
using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
    [SerializeField] private float _reloadTime;

    private CharacterStates _states;

    public Transform _attackPosition;
    public LayerMask _enemy;
    public float _attackRange;
    public GameObject _dialoguePanel;
    public GameObject _fireballPrefab;

    private void Start() => _states = GetComponent<CharacterStates>();

    private void Update()
    {
        bool universalCheckForAttack = gameObject.GetComponent<Animator>().GetBool("IsJumping") == false && !_dialoguePanel.activeInHierarchy;
        if (_reloadTime <= 0)
        {
            if (Input.GetMouseButton(0) && universalCheckForAttack)
                DefaultAttack();

            if (Input.GetMouseButton(0) && universalCheckForAttack && Input.GetKey(KeyCode.Q) && gameObject.GetComponent<CharacterStates>()._mana >= 2)
                FireBallAttack();
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
            enemies[i].GetComponent<EnemyStates>()._hp -= _states._damage;
        }
    }

    private void FireBallAttack()
    {
        _reloadTime = 1;
        gameObject.GetComponent<Animator>().SetInteger("Attack", 2);
        if (gameObject.GetComponent<CharacterMover>()._horizontalDirection >= 0)
        {
            Instantiate(_fireballPrefab, new Vector2(gameObject.transform.position.x + 1, gameObject.transform.position.y + 0.6f), Quaternion.identity);
        }
        else
        {
            Instantiate(_fireballPrefab, new Vector2(gameObject.transform.position.x - 10, gameObject.transform.position.y + 0.6f), Quaternion.identity);
        }
    }

    public void StopAttackAnimations()
    {
        gameObject.GetComponent<Animator>().SetInteger("Attack", 0);
    }
}