using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    public GameObject Events;

    public TextMeshProUGUI popscore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //init
        float tt_beginTime = Events.GetComponent<TenTimer>().beginTime;
        float tt_countdown = Events.GetComponent<TenTimer>().countdown;
        bool tt_isActive = Events.GetComponent<TenTimer>().isActive;

        float st_beginTime = Events.GetComponent<SpeedTimer>().beginTime;
        float st_count = Events.GetComponent<SpeedTimer>().count;
        bool st_isActive = Events.GetComponent<SpeedTimer>().isActive;

        //Ten Second Timer
        if (tt_isActive == true && tt_beginTime > 0)
        {
            int tt_disptime = Mathf.FloorToInt(tt_beginTime) + 1;
            popscore.text = tt_disptime.ToString("0");
        } else if (tt_isActive == true && tt_beginTime <= 0 && tt_countdown > 0)
        {
            popscore.text = tt_countdown.ToString("0.00");
        }
        //Speed test
        else if (st_isActive == true && st_beginTime > 0)
        {
            int st_disptime = Mathf.FloorToInt(st_beginTime) + 1;
            popscore.text = st_disptime.ToString("0");
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
