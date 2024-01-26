using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideToTheLeft : MonoBehaviour
{
    public float moveSpeed = 3;
    public string tpPos = null;
    public float tpTo;
    public bool randomizeHeight;
    public float heightMin = -2.5f;
    public float heightMax = 2.75f;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        if (tpPos != string.Empty)
        {
            if (transform.position.x <= float.Parse(tpPos) && !randomizeHeight)
            {
                transform.position = new Vector3(tpTo, transform.position.y, transform.position.z);
            }
            else if (transform.position.x <= float.Parse(tpPos) && randomizeHeight)
            {
                transform.position = new Vector3(tpTo, Random.Range(heightMin, heightMax), transform.position.z);
            }
        }
    }
}
