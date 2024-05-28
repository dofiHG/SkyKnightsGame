using UnityEngine; 
 
public class StupidEnemiesMover : MonoBehaviour 
{ 
    public int direction = 1; 

    public float _speed; 
    public LayerMask _layer; 

    private void Update() 
    {
        Move();
    }

    private void Move()
    {
        RaycastHit2D hitL = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), 0.5f, _layer);
        RaycastHit2D hitR = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 0.5f, _layer);
        transform.Translate(direction * _speed * Time.deltaTime * Vector2.right);
        if (hitL)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            direction = 1;
        }
        if (hitR)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            direction = -1;
        }
    }
} 
 