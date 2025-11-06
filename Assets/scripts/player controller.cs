using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float MovementX;
    private float MovementY;
    public float speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMove(InputValue MovementValue)
    {
        Vector2 MovementVector = MovementValue.Get<Vector2>(); 
        MovementX = MovementVector.x;
        MovementY = MovementVector.y;

    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3 (MovementX, 0.0f, MovementY);
        rb.AddForce(movement*speed);
    }
}
