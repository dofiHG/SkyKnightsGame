using UnityEngine; 
 
public class StupidEnemiesMover : MonoBehaviour 
{ 
    public int direction = 1; 

    public float _speed; 
    public LayerMask _layer;
    public LayerMask _layer1;

    private void Update() 
    {
        Move();
    }

    private void Move()
    {
        RaycastHit2D hitL = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), 0.5f, _layer);
        RaycastHit2D hitR = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 0.5f, _layer);

        if (gameObject.GetComponent<Collider2D>().IsTouchingLayers(_layer1)) { direction *= -1; }
        gameObject.GetComponent<SpriteRenderer>().flipX = direction > 0 ? true: false;

        transform.Translate(direction * _speed * Time.deltaTime * Vector2.right);
        
        if (hitL)
        {
            direction = 1;
        }
        if (hitR)
        {
            direction = -1;
        }
    }
} 
