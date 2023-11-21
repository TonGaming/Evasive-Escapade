using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChopperController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 8f;

    Rigidbody chopperRigidbody;
    Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        chopperRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        FlyingAround();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            chopperRigidbody.velocity = new Vector3(chopperRigidbody.velocity.x, chopperRigidbody.velocity.y * jumpForce, chopperRigidbody.velocity.z);
        }
    }

    void FlyingAround()
    {
        Vector2 chopperMovement = new Vector3(moveInput.x * moveSpeed * Time.deltaTime, chopperRigidbody.velocity.z);
        chopperRigidbody.velocity = chopperMovement;

    }

    
}
