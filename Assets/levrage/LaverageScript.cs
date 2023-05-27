using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaverageScript : MonoBehaviour
{
    public bool isOn;
    public Sprite off;
    public Sprite on;

    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr.sprite = off;
        isOn = false;
    }


    private void Update()
    {
        if(isOn)
        {
            sr.sprite = on;
        }
    }
    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {
            Destroy(other.gameObject);
            isOn = true;
        }
    }

}
