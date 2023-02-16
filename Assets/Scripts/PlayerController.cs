using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float x;
    public float y;
    public float moveSpeed;
    public float jumpVelocity = 10f;
    private Rigidbody rigidBody;

    public float distanceToGround = 1.25f;
    public LayerMask groundLayer;

    public Vector2 turn;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Move();
        Jump();

        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }

    void Jump()
    {
        bool isPlayerGrounded = Physics.Raycast(transform.position, Vector3.down, distanceToGround, groundLayer);

        if (isPlayerGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }
    }

    void Move()
    {
        transform.Translate(x * moveSpeed, 0, 0);
        x = Input.GetAxisRaw("Horizontal");
        transform.Translate(0, 0, y * moveSpeed);
        y = Input.GetAxisRaw("Vertical");
    }
}
