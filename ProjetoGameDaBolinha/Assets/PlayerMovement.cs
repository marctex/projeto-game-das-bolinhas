using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float speedPlayer = 5f;
    private Rigidbody2D playerRB;
    private Vector2 movementPlayer;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.linearVelocity = movementPlayer * speedPlayer;
        
    }

    private void OnMove(InputValue value)
    {
        movementPlayer = value.Get<Vector2>();
    }
    
}
