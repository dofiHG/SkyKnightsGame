using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
    [SerializeField] private float _reloadTime;

    private CharacterStates _states;

    public Transform _attackPosition;
    public LayerMask _enemy;
    public float _attackRange;


    private void Start() => _states = GetComponent<CharacterStates>();

    private void Update()
    {
        if (_reloadTime <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                _reloadTime = 1;
                Collider2D[] enemies = Physics2D.OverlapCircleAll(_attackPosition.position, _attackRange, _enemy);

                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].GetComponent<EnemyStates>()._hp -= _states._damage;
                }
            }
        }
        else { _reloadTime -= Time.deltaTime; }
        
    }
}
