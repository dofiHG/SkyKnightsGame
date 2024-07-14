using UnityEngine;

public class SaveSafePosition : MonoBehaviour
{
    public Vector2 _currentPostion;
    private void Start() => SavePosition();

    private void SavePosition()
    {
        if (gameObject.GetComponent<CharacterMover>()._isGround == true && gameObject.GetComponent<CharacterStates>()._hp > 0)
            _currentPostion = transform.position;
        Invoke("SavePosition", 3);
    }
}
