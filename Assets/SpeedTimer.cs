using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTimer : MonoBehaviour
{
    public float beginTime = 3;
    public float count = 0;
    public float resultsTime = 3;
    public float popcounted = 0;
    public bool isActive = false;
    public GameObject mocha;
    public GameObject discord;

    // Start is called before the first frame update
    public void Initiate()
    {
        if (isActive == false)
        {
            isActive = true;
            mocha.GetComponent<Pop>().canPop = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true && beginTime > 0)
        {
            beginTime -= Time.deltaTime;
        }

        if (isActive == true && beginTime <= 0 && popcounted < 100)
        {
            mocha.GetComponent<Pop>().canPop = true;
            count += Time.deltaTime;
        }

        if (isActive == true && popcounted >= 100 && resultsTime > 0)
        {
            mocha.GetComponent<Pop>().canPop = false;
            resultsTime -= Time.deltaTime;
        }

        if (isActive == true && resultsTime <= 0)
        {
            mocha.GetComponent<Pop>().canPop = true;
            isActive = false;
            beginTime = 3;
            count = 0;
            resultsTime = 3;
            popcounted = 0;
        }
    }
}
