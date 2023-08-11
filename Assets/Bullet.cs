using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        LaverageScript ls = collision.gameObject.GetComponent<LaverageScript>();
        if (ls) { 
            ls.Enable();
        }
        ChiScript cs = collision.gameObject.GetComponent<ChiScript>();
        if (cs)
        {
            cs.sleep();
        }
        WizardController ws = collision.gameObject.GetComponent<WizardController>();
        if(ws){
            ws.gameover();
        }

        Destroy(this.gameObject);
    }
}
