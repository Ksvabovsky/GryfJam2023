using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;

public class ChiScript : MonoBehaviour
{
    Animator animator;

    public Transform player;
    public Transform aim;
    public Transform bulletParent;

    float dist;
    public float range;
    public float Cooldown;
    public float cool;

    public GameObject bullet;

    bool active;

    void Start()
    {
        animator= GetComponent<Animator>();
        player = WizardController.Instance.gameObject.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dist = Vector3.Distance(player.position,this.transform.position);
        if(dist < range)
        {
            active= true;
            animator.SetBool("isAngy", true);
        }
        else
        {
            active= false;
            animator.SetBool("isAngy", false);
        }

        cool = cool - Time.deltaTime;
        if (active)
        {
            Attack();
        }
    }


    void Attack()
    {
        
        if(cool < 0)
        {
            Shoot();
            cool = Cooldown;
        }
        
    }

    void Shoot()
    {
        aim.LookAt(player.position);
        GameObject proj = Instantiate(bullet, aim.position, aim.rotation, bulletParent);
        Rigidbody rb = proj.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * 10f, ForceMode.Impulse);
        //proj.transform.Scale= Vector3.one;
    }

    public void sleep()
    {
        Destroy(this.gameObject);
    }
}
