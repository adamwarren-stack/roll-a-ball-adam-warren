using UnityEngine;
using UnityEngine. InputSystem;
public class PlayerController : MonoBehaviour
{
    private RigidBody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponet<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMove(InputValue MovementValue)
    {
        Vector2 MovementVector = MovementValue.Get<Vector2>(); 
    }
    private void Fixedupdate()
    {
        rb.AddForce(Movement);
    }
}
