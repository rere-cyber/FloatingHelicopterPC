using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;

    private float _speed = 90f;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Vector2.zero;
        Rigidbody2D.AddForce(Vector2.left * _speed);
    }
}
