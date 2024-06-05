using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public bool falling;
    [SerializeField]
    float weight;
    Vector3 initialPos;
    PolygonCollider2D col;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        col = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            col.enabled = true;
        }
        else
        {
            col.enabled = false;
        }
        if (falling)
        {
            transform.position = new Vector3(transform.position.x - 2 * Time.deltaTime, transform.position.y - weight * Time.deltaTime, transform.position.z);
        }
        if (falling && transform.position.y < -10)
        {
            falling = false;
            transform.position = initialPos;
        }
    }
}
