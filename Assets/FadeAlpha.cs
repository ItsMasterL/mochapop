using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAlpha : MonoBehaviour
{
    public bool fadeOnAwake = true;
    public bool trigger = false;
    public bool startInvisible = false;
    public bool fadeToBlack = false;
    static bool startflags;
    Color color;

    private void Awake()
    {
        if (startInvisible && !startflags)
        {
            color = GetComponent<Image>().color;
            color.a = 0;
            GetComponent<Image>().color = color;
            startflags = true;
        }
    }

    private void Update()
    {
        if (fadeToBlack)
        {
            color = GetComponent<Image>().color;
            color = new Color(0, 0, 0, color.a);
            GetComponent<Image>().color = color;
        }
        else
        {
            color = GetComponent<Image>().color;
            color = new Color(1, 1, 1, color.a);
            GetComponent<Image>().color = color;
        }
        if (fadeOnAwake || trigger)
        {
            color = GetComponent<Image>().color;
            color.a -= Time.deltaTime;
            GetComponent<Image>().color = color;
            if (color.a <= 0)
            {
                fadeOnAwake = false;
                trigger = false;
            }
        }
    }
}
