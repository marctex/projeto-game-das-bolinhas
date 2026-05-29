using UnityEngine;

public class PlayerController : MonoBehaviour
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
        movementPlayer.x = Input.GetAxisRaw("Horizontal");
        movementPlayer.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + movementPlayer.normalized * speedPlayer * Time.deltaTime);
    }
}
