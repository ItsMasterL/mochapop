using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
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
        //init
        float tt_beginTime = TenTime.GetComponent<TenTimer>().beginTime;
        float tt_countdown = TenTime.GetComponent<TenTimer>().countdown;
        bool tt_isActive = TenTime.GetComponent<TenTimer>().isActive;

        float st_beginTime = Speedy.GetComponent<SpeedTimer>().beginTime;
        float st_count = Speedy.GetComponent<SpeedTimer>().count;
        bool st_isActive = Speedy.GetComponent<SpeedTimer>().isActive;

        //Ten Second Timer
        if (tt_isActive == true && tt_beginTime > 0)
        {
            popscore.text = tt_beginTime.ToString("0");
        } else if (tt_isActive == true && tt_beginTime <= 0 && tt_countdown > 0)
        {
            popscore.text = tt_countdown.ToString("0.00");
        } else if (st_isActive == true && st_beginTime > 0)
        {
            popscore.text = st_beginTime.ToString("0");
        }
        else if (st_isActive == true && st_beginTime <= 0)
        {
            popscore.text = st_count.ToString("0.000");
        }
        else
        {
            popscore.text = "";
        }
    }
}
