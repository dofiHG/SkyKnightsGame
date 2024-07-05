using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public GameObject _pausePnael;
    public void EnablePauseMenu() => _pausePnael.GetComponent<Animator>().SetBool("Pause", true);

    public void DisablePauseMenu() => _pausePnael.GetComponent<Animator>().SetBool("Pause", false);
}
