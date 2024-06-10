using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class FireBallActions : MonoBehaviour
{
    private int _speed = 8;
    void Update()
    {
        Mover();
    }

    public void Mover()
    {
        int direction = gameObject.GetComponent<SpriteRenderer>().flipX == false ? 1 : -1;
        transform.Translate(_speed * Time.deltaTime * Vector2.right * direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Enemy")
        {
            try { collision.gameObject.GetComponent<Animator>().SetBool("Damage", true); }
            finally { collision.gameObject.GetComponent<EnemyStates>()._hp -= 2; }
            int dir = gameObject.transform.position.x > collision.transform.position.x ? -3 : 3;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(dir, 0), ForceMode2D.Impulse);
        }
        gameObject.GetComponent<Animator>().SetBool("Boom", true);
        _speed = 0;
        StartCoroutine(WaitBeforeDestroy());
    }

    private IEnumerator WaitBeforeDestroy()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
}
