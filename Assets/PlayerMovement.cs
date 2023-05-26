using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    float HorMovement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HorMovement = Input.GetAxis("Horizontal");

        rb.AddForce(this.transform.right * speed * HorMovement  * Time.deltaTime, ForceMode.Impulse);
        if(HorMovement <= 0.5f && HorMovement >= -0.5f){
            rb.velocity = new Vector3(0f, rb.velocity.y, 0f);
        }
    }

    void Jump()
    {
        
    }
}
