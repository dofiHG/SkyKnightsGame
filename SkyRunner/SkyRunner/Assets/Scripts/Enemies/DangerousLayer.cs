using UnityEngine;

public class DangerousLayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        try 
        { 
            collision.gameObject.GetComponent<CharacterStates>()._hp = 0;
            collision.gameObject.GetComponent<EnemyStates>()._hp = 0;
        }
        catch { }
    }
}
