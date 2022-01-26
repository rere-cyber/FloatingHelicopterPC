using UnityEngine;

public class Fly : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;

    private Vector2 _direction = new Vector2(0, 1);

    private bool _isPressed = false;

    private float _maxSpeed = 2f;

    private float _power = 100f;

    private void Awake()
    {
        Rigidbody2D.isKinematic = true;
    }
    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
            Rigidbody2D.isKinematic = false;
            CheckInput();
        
    }

    private void FixedUpdate()
    {
        if (_isPressed == true)
        {
            FlightUp();
        }

        ClampFallSpeed();
    }

    private void FlightUp()
    {
        Rigidbody2D.velocity = Vector2.zero;
        Rigidbody2D.AddForce(_direction * _power);
    }

    private void CheckInput()
    {
        if (Input.GetMouseButton(0))
        {
            _isPressed = true;
        }
        else
        {
            _isPressed = false;
        }
        
    }

    private void ClampFallSpeed()
    {
        if(Rigidbody2D.velocity.magnitude > _maxSpeed)
        {
            Rigidbody2D.velocity = Rigidbody2D.velocity.normalized * _maxSpeed;
        }
    }
}
