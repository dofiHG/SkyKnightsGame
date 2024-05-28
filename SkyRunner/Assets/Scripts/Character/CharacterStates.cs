using UnityEngine;
using UnityEngine.UI;

public class CharacterStates : MonoBehaviour
{
    
    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private Slider _healtSlider;
    [SerializeField] private Slider _manaSlider;

    public int _mana = 10;
    public int _damage = 1;
    public int _hp = 5;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _healtSlider.value = _hp;
        _manaSlider.value = _mana;

        if (_hp <= 0) 
        {
            _animator.SetBool("Death", true);
            Invoke("EnableDeathScreen", 1.7f);
            gameObject.GetComponent<Collider2D>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static; 
        }
    }

    private void EnableDeathScreen() => _deathPanel.SetActive(true);
}
