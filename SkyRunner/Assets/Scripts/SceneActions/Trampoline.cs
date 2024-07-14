using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] private float _boostForce;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") { collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, _boostForce), ForceMode2D.Impulse); }
    }
}
