using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject firstParalaxPrefab;
    public float direction;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "STparalax")
        {
            Debug.Log("exit");
            Destroy(other.gameObject);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "STparalax")
        {
            Debug.Log("enter");
            GameObject newGameObj = Instantiate(firstParalaxPrefab);
            newGameObj.transform.position = new Vector3(other.transform.position.x + 65 * direction, other.transform.position.y, other.transform.position.z);
        }
    }
}
