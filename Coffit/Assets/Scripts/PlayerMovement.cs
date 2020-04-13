using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalMove;
    public float verticalMove;
    public CharacterController player;

    public float playerSpeed;
    private Vector3 movePlayer;
    private Vector3 playerInput;

    private float gravity = 9.8f;

    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;
    
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        camDirection();
        movePlayer = playerInput.x * camRight + playerInput.z * camForward;
        movePlayer = movePlayer * playerSpeed;
        player.transform.LookAt(player.transform.position + movePlayer);
        setGravity();
        player.Move(movePlayer * playerSpeed * Time.deltaTime);
    }

    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }

    void setGravity()
    {
        movePlayer.y = -gravity;

        if(player.isGrounded)
        {
            movePlayer.y = -gravity * Time.deltaTime;
        } else
        {
            movePlayer.y += gravity * Time.deltaTime;
        }
    }
}
