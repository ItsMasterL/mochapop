using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Achievement : MonoBehaviour
{
    public float rainbowSpeed = 5;
    float hue;
    public float sat = 1;
    public float bri = 1;
    TextMeshProUGUI tmp;

    public float alpha;
    
    private void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
            Color.RGBToHSV(tmp.color, out hue, out sat, out bri);
            hue += rainbowSpeed * Time.deltaTime / 50;
            if (hue >= 1)
            {
                hue = 0;
            }
            tmp.color = Color.HSVToRGB(hue, sat, bri);

        if (alpha > 0)
        {
            alpha -= Time.deltaTime;
        }

        if (alpha < 0)
        {
            alpha = 0;
        }

        if (alpha <= 1)
        {
            tmp.color = new Vector4(tmp.color.r, tmp.color.g, tmp.color.b, alpha);
        }
    }
}
