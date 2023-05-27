using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class ParalaxScript : MonoBehaviour
{

    public Transform first_line;
    public Transform second_line;
    public Transform third_line;

    float fl_multiplyer;
    float sl_multiplyer;
    float tl_multiplyer;

    int Level_left;
    int Level_right;

    Vector3 camPos;

    float level_length;
    float percent;

    // Start is called before the first frame update
    void Start()
    {
        level_length = Level_left + Level_right;
        fl_multiplyer = 1;
        sl_multiplyer = 1.5f;
        tl_multiplyer = 2.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        first_line.position = new Vector3(transform.position.x*0.3f, first_line.position.y, first_line.position.z);
        second_line.position = new Vector3(transform.position.x*0.6f, second_line.position.y, second_line.position.z);
        third_line.position = new Vector3(transform.position.x*0.9f, third_line.position.y, third_line.position.z);
    }
}
