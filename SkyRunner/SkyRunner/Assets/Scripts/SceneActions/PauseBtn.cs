using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public GameObject _pausePnael;
    public GameObject _hpPanel;

    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStates>()._hp == 5) { _hpPanel.SetActive(false); }
        else { _hpPanel.SetActive(true); }
    }

    public void EnablePauseMenu() => _pausePnael.GetComponent<Animator>().SetBool("Pause", true);

    public void DisablePauseMenu()
    {
        _pausePnael.GetComponent<Animator>().SetBool("Pause", false);
        _pausePnael.transform.position = new Vector2(transform.position.x, -9000);
    }
}
