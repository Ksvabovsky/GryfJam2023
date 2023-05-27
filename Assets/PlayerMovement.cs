using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class PlayerMovement : MonoBehaviour
{
    PlayerInput pl;
    PlayerInputActions actions;

    [SerializeField]
    SpriteRenderer PlayerSprite;

    Rigidbody rb;
    [SerializeField]
    float GroundSpeed;
    [SerializeField]
    float AirSpeed;
    [SerializeField]
    float JumpForce;
    [SerializeField]
    float HorMovement;
    [SerializeField]
    int jumps;
    bool isJumping;

    Vector3 velocity = Vector3.zero;

    public float deadzone;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        pl = GetComponent<PlayerInput>();

        actions = new PlayerInputActions();
        actions.Player.Enable();
        actions.Player.Jump.performed += Jump;

        jumps = 3;
        isJumping = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("X vel: " + rb.velocity.x);


        Vector2 joy = actions.Player.Move.ReadValue<Vector2>();
        HorMovement = joy.x;
        Debug.Log("X: " + joy.x);
        if (joy.x < -0.05)
        {
            PlayerSprite.flipX= true;
        }
        if (joy.x > 0.05)
        {
            PlayerSprite.flipX= false;
        }
        if (joy.x > deadzone || joy.x < -deadzone)
        {
            if (isJumping == false)
            {
                rb.AddForce(this.transform.right * GroundSpeed * joy.x * Time.deltaTime, ForceMode.Impulse);
            }
            else
            {
                rb.velocity = Vector3.SmoothDamp(rb.velocity, this.transform.right * AirSpeed * joy.x * Time.deltaTime,ref velocity, 1f);
                rb.AddForce(this.transform.right * AirSpeed * joy.x * Time.deltaTime, ForceMode.Impulse);
            }
        }
        else
        {
            if (isJumping == false)
            {
                rb.velocity = new Vector3(0f, rb.velocity.y);
            }
        };
    }

    public void Jump(InputAction.CallbackContext context)
    {

        if (context.performed)
        {
            Vector2 joy = actions.Player.Move.ReadValue<Vector2>();
            if (jumps > 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0f);
                if (isJumping == false)
                {
                    //rb.velocity = Vector3.SmoothDamp(rb.velocity, new Vector3(GroundSpeed * joy.x * Time.deltaTime, 10f, 0f), ref velocity, 1f);
                    rb.AddForce(GroundSpeed * joy.x * Time.deltaTime, JumpForce,0f, ForceMode.Impulse);
                }
                else
                {
                    //rb.velocity = Vector3.SmoothDamp(rb.velocity, new Vector3(AirSpeed * joy.x * Time.deltaTime, 10f, 0f), ref velocity, 1f);
                    rb.AddForce(AirSpeed * joy.x * Time.deltaTime, JumpForce, 0f, ForceMode.Impulse);
                }
                Debug.Log("chuj");
                isJumping = true;
                jumps--;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            ResetJumps();
        }
    }

    public void ResetJumps()
    {
        jumps = 3;
    }
}
