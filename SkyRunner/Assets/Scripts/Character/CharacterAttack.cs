using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
    private CharacterStates _states;

    public Transform _attackPosition;
    public LayerMask _enemy;
    public float _attackRange;


    private void Start() => _states = GetComponent<CharacterStates>();

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Collider2D[] enemies = Physics2D.OverlapCircleAll(_attackPosition.position, _attackRange, _enemy);

            for (int i = 0;  i < enemies.Length; i++)
            {
                enemies[i].enabled = false;
            }
        }
        
    }
}
