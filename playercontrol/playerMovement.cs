using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public PlayerControls movementController;
    public CharacterController playerChar;
    public float walkSpeed = 0f;
    public float sprintSpeed = 0f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;

    private bool isGrounded;
    Vector3 velocity;
    private InputAction movement;
    private InputAction sprint;

    private void Awake()
    {
        movementController = new PlayerControls();
    }

    private void OnEnable()
    {
        movement = movementController.movementAndInteractions.Move;
        movement.Enable();

        sprint = movementController.movementAndInteractions.Sprint;
        sprint.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
        sprint.Disable();
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float forBack = movement.ReadValue<Vector2>().x;
        float sideToSide = movement.ReadValue<Vector2>().y;
        Vector3 moveDir = transform.right * forBack + transform.forward * sideToSide;
        if (sprint.IsPressed())
        {
            playerChar.Move(moveDir * sprintSpeed * Time.deltaTime);
        }
        else { playerChar.Move(moveDir * walkSpeed * Time.deltaTime); }
        velocity.y += gravity * Time.deltaTime;
        playerChar.Move(velocity * Time.deltaTime);
    }
}
