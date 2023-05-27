using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GhostController : MonoBehaviour
{
    PlayerInput pl;
    GhostInputActions actions;

    [SerializeField]
    SpriteRenderer PlayerSprite;

    [SerializeField]
    Animator animator;

    Rigidbody rb;
    Collider playerCollider;

    [SerializeField]
    InputAction actionReference;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        pl = GetComponent<PlayerInput>();

        actions = new GhostInputActions();

        actions.Ghost.Enable();
        //pl.actions[actions.Ghost.Jump.name].performed += Jump;
        //pl.actions[actions.Ghost.Dodge.name].performed += Dodge;



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 joy = pl.actions[actions.Ghost.Move.name].ReadValue<Vector2>();
        if (joy.x < -0.05)
        {
            PlayerSprite.flipX = true;
        }
        if (joy.x > 0.05)
        {
            PlayerSprite.flipX = false;
        }
        this.transform.Translate(joy.x * Time.deltaTime, joy.y *Time.deltaTime, 0f);
    }

    public void Jump(InputAction.CallbackContext context)
    {

        if (context.performed)
        {

        }
    }

    public void Dodge(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }

    }
}


