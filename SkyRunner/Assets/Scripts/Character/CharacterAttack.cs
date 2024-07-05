using UnityEngine;
using UnityEngine.EventSystems;
using YG;

public class CharacterAttack : MonoBehaviour
{
    [SerializeField] private float _reloadTime;

    public Transform _attackPosition;
    public LayerMask _enemy;
    public float _attackRange;
    public GameObject _dialoguePanel;
    public GameObject _fireballPrefab;

    private void Update()
    {
        bool universalCheckForAttack = gameObject.GetComponent<Animator>().GetBool("IsJumping") == false && !_dialoguePanel.activeInHierarchy;
        
        if (_reloadTime <= 0)
        {
            if (YandexGame.savesData.device == 0)
            {

                if (Input.GetMouseButton(0) && universalCheckForAttack && Input.GetKey(KeyCode.Q) && gameObject.GetComponent<CharacterStates>()._mana >= 2)
                    FireBallAttack();

                if (Input.GetMouseButton(0) && universalCheckForAttack)
                    DefaultAttack();

                if ((gameObject.GetComponent<Animator>().GetBool("IsJumping") == true && !_dialoguePanel.activeInHierarchy) && gameObject.GetComponent<CharacterMover>()._horizontalDirection != 0 && Input.GetMouseButton(0))
                    JumpAttack();
            }
            
        }
        else { _reloadTime -= Time.deltaTime; }
    }

    public void DefaultAttack()
    {
        _reloadTime = 1;
        gameObject.GetComponent<Animator>().SetInteger("Attack", 1);
        Collider2D[] enemies = Physics2D.OverlapCircleAll(_attackPosition.position, _attackRange, _enemy);

        for (int i = 0; i < enemies.Length; i++)
        {
            try { enemies[i].GetComponent<Animator>().SetBool("Damage", true); }
            finally { enemies[i].GetComponent<EnemyStates>()._hp -= gameObject.GetComponent<CharacterStates>()._damage; }
        }
    }

    public void FireBallAttack()
    {
        _reloadTime = 1;
        gameObject.GetComponent<Animator>().SetInteger("Attack", 1);
        gameObject.GetComponent<CharacterStates>()._mana -= 2;
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
        gameObject.GetComponent<Animator>().SetInteger("Attack", 2);
        gameObject.GetComponent<Collider2D>().isTrigger = true;
        float xOffset = gameObject.GetComponent<CharacterMover>()._horizontalDirection > 0 ? 0.24f : -0.24f;
        gameObject.GetComponent<Collider2D>().offset = new Vector2(xOffset, gameObject.GetComponent<Collider2D>().offset.y / 2);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "DangerousLayer") { gameObject.GetComponent<CharacterStates>()._hp = 0; }
        if (collision.name == "Ground") 
        {
            gameObject.GetComponent<Collider2D>().isTrigger = false;
            gameObject.GetComponent<Animator>().SetInteger("Attack", 0);
        }

        if (collision.tag == "Enemy" && _reloadTime <= 0) 
        {
            _reloadTime = 1;
            try { collision.gameObject.GetComponent<Animator>().SetBool("Damage", true); }
            finally { collision.gameObject.GetComponent<EnemyStates>()._hp -= 3; }
            int dir = gameObject.transform.position.x > collision.transform.position.x ? -3 : 3;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(dir, 0), ForceMode2D.Impulse);
        }  
    }

    public void MobileDefaultAttack(int id)
    {
        if (_reloadTime <= 0 && gameObject.GetComponent<CharacterMover>()._isGround)
        {
            if (id == 0)
            {
                DefaultAttack();
                gameObject.GetComponent<Animator>().Play("DefaultAttack");
            }

            else if (id == 1 && gameObject.GetComponent<CharacterStates>()._mana >= 2)
            {
                FireBallAttack();
                gameObject.GetComponent<Animator>().Play("DefaultAttack");
            }
        }
        
    }
}
