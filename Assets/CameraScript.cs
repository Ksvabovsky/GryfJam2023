using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Player;

    [SerializeField]
    private Vector3 CamPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Slerp(transform.position, Player.position + CamPos, 10f* Time.deltaTime);
    }
}
