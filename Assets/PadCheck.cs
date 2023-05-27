using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PadCheck : MonoBehaviour
{
    PlayerInput pl;
    PlayerInputActions actions;

    public TMP_Text text;
    public GameObject image;

    // Start is called before the first frame update
    void Awake()
    {
        pl = GetComponent<PlayerInput>();
        actions = new PlayerInputActions();
        actions.Player.Enable();
        pl.actions[actions.Player.Enter.name].performed += Enter;

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Enter(InputAction.CallbackContext context)
    {

        if (context.performed)
        {
            text.gameObject.SetActive(false);
            image.gameObject.SetActive(true);
        }
    }

}
