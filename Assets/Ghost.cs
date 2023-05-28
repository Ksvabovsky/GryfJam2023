using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Target;
    public GameObject bullet;
    public Transform aim;
    public Transform aimDir;
    public Transform bulletParent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = Vector3.Slerp(this.transform.position,Target.position,2f*Time.deltaTime);
        
    
    
    }

    public void Shoot(float x, float y)
    {
        
        aim.position = this.transform.position + new Vector3(x * 2, y * 2);
        aimDir.LookAt(aim.position);
        GameObject proj = Instantiate(bullet, aimDir.position,aimDir.rotation,bulletParent);
        Rigidbody rb = proj.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * 10f,ForceMode.Impulse);
    }
}
