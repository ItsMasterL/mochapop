using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAlpha : MonoBehaviour
{
    public bool fadeOnAwake = true;
    public bool trigger = false;
    public bool startInvisible = false;
    static bool startflag;
    Color color;

    private void Awake()
    {
        if (startInvisible && !startflag)
        {
            color = GetComponent<Image>().color;
            color.a = 0;
            GetComponent<Image>().color = color;
            startflag = true;
        }
    }

    private void Update()
    {
        if (fadeOnAwake || trigger)
        {
            color = GetComponent<Image>().color;
            color.a -= Time.deltaTime;
            GetComponent<Image>().color = color;
            if (color.a <= 0)
            {
                fadeOnAwake = false;
            }
        }
    }
}
