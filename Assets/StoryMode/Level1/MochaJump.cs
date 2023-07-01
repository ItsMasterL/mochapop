using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochaJump : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (GetComponent<Pop>().isAndroid == true && Input.GetMouseButtonDown(0)))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 8);
        }
    }
}
