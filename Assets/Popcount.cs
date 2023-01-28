using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Popcount : MonoBehaviour
{
    public GameObject mocha;
    public GameObject Events;

    public Color color1 = new Vector4(0, 0, 0, 1);
    public Color color2 = new Vector4(0, 0, 0, 1);

    public TextMeshProUGUI popscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Events.GetComponent<TenTimer>().isActive == true)
        {
            popscore.text = Events.GetComponent<TenTimer>().popcounttimed.ToString();
            popscore.color = color2;
        }
        else if (Events.GetComponent<SpeedTimer>().isActive == true)
        {
            popscore.text = Events.GetComponent<SpeedTimer>().popcounted.ToString();
            popscore.color = color2;
        }
        else
        {
            int popcount = Pop.popcount;
            popscore.text = popcount.ToString();
            popscore.color = color1;
        }
    }
}
