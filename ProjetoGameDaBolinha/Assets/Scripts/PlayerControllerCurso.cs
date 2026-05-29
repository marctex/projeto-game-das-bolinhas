using UnityEngine;

public class PlayerControllerCurso : MonoBehaviour
{
    public float speedPlayer;
    private Rigidbody2D playerRB;
    private Vector2 movementPlayer;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }

    private void MovementPlayer()
    {
        movementPlayer = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        playerRB.linearVelocity = movementPlayer.normalized * speedPlayer;
    }
}
