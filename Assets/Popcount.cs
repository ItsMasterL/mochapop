using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popcount : MonoBehaviour
{
    public GameObject mocha;
    public GameObject TenTime;
    public GameObject Speedy;

    public Text popscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TenTime.GetComponent<TenTimer>().isActive == true)
        {
            popscore.text = TenTime.GetComponent<TenTimer>().popcounttimed.ToString();
        }
        else if (Speedy.GetComponent<SpeedTimer>().isActive == true)
        {
            popscore.text = Speedy.GetComponent<SpeedTimer>().popcounted.ToString();
        }
        else
        {
            int popcount = mocha.GetComponent<Pop>().popcount;
            popscore.text = popcount.ToString();
        }
    }
}
