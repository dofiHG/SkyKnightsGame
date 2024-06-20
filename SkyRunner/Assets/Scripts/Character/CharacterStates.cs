using UnityEngine;
using UnityEngine.UI;

public class CharacterStates : MonoBehaviour
{
    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private Slider _healtSlider;
    [SerializeField] private Slider _manaSlider;

    public bool _hasStarTaken;
    public int _mana = 10;
    public int _damage = 1;
    public int _hp = 5;

    private void Update()
    {
        _healtSlider.value = _hp;
        _manaSlider.value = _mana;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_deathPanel.GetComponent<Animator>().GetBool("Finish") != true && GameObject.FindGameObjectWithTag("FinishPanel").GetComponent<Animator>().GetBool("Finish") != true)
            {
                if (_pausePanel.GetComponent<Animator>().GetBool("Pause") != true)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMover>().enabled = false;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterAttack>().enabled = false;
                    _pausePanel.GetComponent<Animator>().SetBool("Pause", true);
                }
                 
                else
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMover>().enabled = true;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterAttack>().enabled = true;
                    _pausePanel.GetComponent<Animator>().SetBool("Pause", false);
                }
            }        
        }

        if (_hp <= 0) 
        {
            gameObject.GetComponent<CharacterMover>()._speed = 0;
            gameObject.GetComponent<Animator>().SetBool("Death", true);
            Invoke("EnableDeathScreen", 1.7f);
            gameObject.GetComponent<Collider2D>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static; 
        }
    }

    private void EnableDeathScreen() => _deathPanel.GetComponent<Animator>().SetBool("Finish", true);
}
