using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _speed = 2;
    private float _horizontalDirection;
    private float _jumpForce = 5;
    private bool _isGround = true;
    private float _raycastDistance = 0.2f;
    private Animator _animator;

    [SerializeField] private AudioSource _stepsSound;

    public SpriteRenderer _sprite;
    public Transform _attackMark;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        JumpAttack();
        Move();
    }

    private void Move()
    {
        _horizontalDirection = Input.GetAxis("Horizontal");
        transform.Translate(_horizontalDirection * _speed * Time.deltaTime * Vector2.right);
        RaycastHit2D _ray = Physics2D.Raycast(_rb.position, Vector2.down, _raycastDistance);
        _isGround = _ray.collider != null ? true : false;

        if (_isGround)
        {
            _animator.SetBool("IsJumping", false);
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                _animator.SetBool("IsRunning", false);
                _rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse); 
            }
        }
        else { _animator.SetBool("IsJumping", true); _animator.SetBool("IsRunning", false); }

        if (_horizontalDirection != 0 && _animator.GetBool("IsJumping") != true) { _animator.SetBool("IsRunning", true); }
        else { _animator.SetBool("IsRunning", false); }

        if (_horizontalDirection < 0) { _sprite.flipX = true; gameObject.GetComponent<CapsuleCollider2D>().offset = new Vector2(-0.24f, 0.67f); _attackMark.localPosition = new Vector2(-0.88f, _attackMark.localPosition.y); }
        if (_horizontalDirection > 0) { _sprite.flipX = false; gameObject.GetComponent<CapsuleCollider2D>().offset = new Vector2(0.24f, 0.67f); _attackMark.localPosition = new Vector2(0.88f, _attackMark.localPosition.y); }

        if (_horizontalDirection != 0 && _isGround)
        {
            if (_stepsSound.isPlaying) { return; }
            else { _stepsSound.Play(); }
        }
        else { _stepsSound.Stop(); } 
    }

    private void JumpAttack()
    {
        if (_isGround == false && Input.GetKeyDown(KeyCode.Mouse0) && _horizontalDirection != 0)
        {
            _animator.SetBool("IsJumping", false);
            _animator.SetBool("JumpAttack", true);
        }
        else if (_isGround == true) { _animator.SetBool("JumpAttack", false); }
    }

    private void DefaultAttack()
    {

    }
}
