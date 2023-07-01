using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideToTheLeft : MonoBehaviour
{
    public float moveSpeed = 3;
    public string tpPos = null;
    public float tpTo;
    public bool randomizeHeight;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        if (tpPos != null && transform.position.x <= float.Parse(tpPos) && !randomizeHeight)
        {
            transform.position = new Vector3(tpTo, transform.position.y, transform.position.z);
        }
        else if (tpPos != null && transform.position.x <= float.Parse(tpPos) && randomizeHeight)
        {
            transform.position = new Vector3(tpTo, Random.Range(-2.5f,2.75f), transform.position.z);
        }
    }
}
