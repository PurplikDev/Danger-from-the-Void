using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PauseMenu pauseMenu;

    [Header("The Usual Stuff")]
    public Rigidbody2D playerRigidbody2D;
    public Transform playerBody;
    public Transform pointer;

    private Vector2 moveDirection;

    [Header("Managers")]
    public PlayerManager playerManager;

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        if(pauseMenu.paused == false) {
            Move();
            Rotate();
        }
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        //float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, /*moveY*/ 0);
    }

    void Move()
    {
        playerRigidbody2D.velocity = new Vector2(moveDirection.x * playerManager.defaultSpeed, moveDirection.y * playerManager.defaultSpeed);
    }

    void Rotate()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, playerBody.transform.position.y));
        Vector3 relativePos = mouseWorld - playerBody.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, relativePos);

        if (rotation.z < playerManager.maxRange && rotation.z > playerManager.minRange)
        { pointer.rotation = rotation; }
    }
}
