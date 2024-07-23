using UnityEngine;
using YG;

public class CharacterMover : MonoBehaviour
{
    private float _jumpForce = 7;
    private float _raycastDistance = 0.2f;
    private bool jump;


    [SerializeField] private AudioSource _stepsSound;

    public bool _isGround = true;
    public Transform _attackMark;
    public Rigidbody2D _rb;
    public float _horizontalDirection;
    public float _speed = 2;
    public Animator _animator;
    public LayerMask _layers;   

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update() => Move();

    private void Move()
    {
        if (YandexGame.savesData.device == 0) { _horizontalDirection = Input.GetAxis("Horizontal"); }
        if (YandexGame.savesData.device == 0) { jump = Input.GetKeyDown(KeyCode.Space); }
        
        transform.Translate(_horizontalDirection * _speed * Time.deltaTime * Vector2.right);
        RaycastHit2D _ray = Physics2D.Raycast(_rb.position, new Vector3(0, -1, 0), _raycastDistance, _layers);
        
        _isGround = _ray.collider != null && (_ray.collider.name == "Ground" || _ray.collider.name.Substring(0) == "MovePlatform") ? true: false;
        if (_isGround)
        {
            gameObject.GetComponent<Collider2D>().isTrigger = false;
            _animator.SetBool("IsJumping", false);
            _animator.SetInteger("Attack", 0);
            if (jump) 
            {
                _animator.SetBool("IsRunning", false);
                _rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse); 
                jump = false;
            }
        }
        else { _animator.SetBool("IsJumping", true); _animator.SetBool("IsRunning", false); jump = false; }

        if (_horizontalDirection != 0 && _animator.GetBool("IsJumping") != true) { _animator.SetBool("IsRunning", true); }
        else { _animator.SetBool("IsRunning", false); }

        if (_horizontalDirection < 0) { gameObject.GetComponent<SpriteRenderer>().flipX = true; gameObject.GetComponent<CapsuleCollider2D>().offset = new Vector2(-0.24f, 0.67f); _attackMark.localPosition = new Vector2(-0.88f, _attackMark.localPosition.y); }
        if (_horizontalDirection > 0) { gameObject.GetComponent<SpriteRenderer>().flipX = false; gameObject.GetComponent<CapsuleCollider2D>().offset = new Vector2(0.24f, 0.67f); _attackMark.localPosition = new Vector2(0.88f, _attackMark.localPosition.y); }

        if (_horizontalDirection != 0 && _isGround)
        {
            if (_stepsSound.isPlaying) { return; }
            else { _stepsSound.Play(); }
        }
        else { _stepsSound.Stop(); } 
    }

    public void ChooseMobileDirection(float direction) => _horizontalDirection = direction;

    public void MobileJump() =>  jump = true;
}