using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5.0f;

    [SerializeField] private float _jumpPower = 5.0f;

    private Rigidbody2D _rigidbody2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (_rigidbody2d == null)
        {
            _rigidbody2d = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody2d == null)
        {
            return;
        }

        _rigidbody2d.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * _moveSpeed, _rigidbody2d.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2d.AddForce(transform.up * _jumpPower, ForceMode2D.Impulse);
        }

        Debug.Log("Hello");
    }
}
