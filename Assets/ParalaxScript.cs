using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class ParalaxScript : MonoBehaviour
{

    Transform first_line;
    Transform second_line;
    Transform third_line;

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
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

    }
}
