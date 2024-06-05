using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descend : MonoBehaviour
{
    [SerializeField]
    float rate;
    [SerializeField]
    bool loop;
    [SerializeField]
    float loopFrom;
    [SerializeField]
    float loopTo;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - (rate * Time.deltaTime));
        if (loop)
        {
            if (transform.position.y < loopFrom)
            {
                transform.position = new Vector3(transform.position.x, loopTo);
            }
        }
    }
}
