using UnityEngine;

public class DangerousLayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) => collision.gameObject.GetComponent<CharacterStates>()._hp = 0;
}
