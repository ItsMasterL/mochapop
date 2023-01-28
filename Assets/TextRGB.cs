using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextRGB : MonoBehaviour
{
    public float rainbowSpeed = 5;
    public float hue;
    public float sat = 1;
    public float bri = 1;
    TextMeshProUGUI tmp;

    public float alpha;
    public bool fadeOut = true;
    public bool outlineChange = false;
    public float hueOffset = 0.1f;
    
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
            if (outlineChange)
            {
            tmp.outlineColor = Color.HSVToRGB(hue + hueOffset, sat, bri);
            /*if (hue + hueOffset < 1)
            {
            tmp.outlineColor = Color.HSVToRGB(hue + hueOffset, sat, bri);
            } else
            {
            tmp.outlineColor = Color.HSVToRGB(hue - hueOffset, sat, bri);
            }
            */
        }

        if (alpha > 0 && fadeOut)
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
