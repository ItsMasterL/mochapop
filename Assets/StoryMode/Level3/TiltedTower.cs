using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltedTower : MonoBehaviour
{
    GameObject mocha;
    [SerializeField]
    GameObject[] tilting;
    [SerializeField]
    float tiltRate;
    [SerializeField]
    float tiltTime;
    [SerializeField]
    float tiltMax;

    float tiltPercent;

    public bool itsJoever;
    // Start is called before the first frame update
    void Start()
    {
        mocha = GameObject.Find("Mocha");
    }

    // Update is called once per frame
    void Update()
    {
        if (tiltTime > 0) tiltTime -= Time.deltaTime;
        else
        {
            tiltPercent += mocha.transform.position.x * tiltRate;
            foreach (GameObject obj in tilting)
            {
                if ((obj.transform.rotation.z < tiltMax && tiltPercent > 0) || (obj.transform.rotation.z > -tiltMax && tiltPercent < 0))
                {
                    obj.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), tiltPercent * Time.deltaTime);
                }
                else
                {
                    itsJoever = true;
                }
            }
            tiltRate += (Time.deltaTime / 100000);
        }
    }
}
