using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDuplicate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(NoDuplicate obj in GameObject.FindObjectsOfType<NoDuplicate>())
        {
            if (obj.gameObject.name == gameObject.name && obj.gameObject != gameObject)
            {
                if (gameObject.name == "DataManager")
                {
                    Destroy(obj.gameObject);
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
