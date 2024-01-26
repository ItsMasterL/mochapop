using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAnim : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, (60f * Time.deltaTime), 0));
    }
}
