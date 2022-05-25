using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgRGB : MonoBehaviour
{
    public float rainbowSpeed = 5;
    public Color originalColor;
    float hue;
    public float sat = 1;
    public float bri = 1;
    Camera cam;
    bool effect;

    public void toggleEffect()
    {
        effect = !effect;
    }

    private void Start()
    {
        cam = GetComponent<Camera>();
        originalColor = cam.backgroundColor;
    }

    private void Update()
    {
        if (effect)
        {
            Color.RGBToHSV(cam.backgroundColor, out hue, out sat, out bri);
            hue += rainbowSpeed / 10000;
            if (hue >= 1)
            {
                hue = 0;
            }
            cam.backgroundColor = Color.HSVToRGB(hue, sat, bri);
        }
        else
        {
            cam.backgroundColor = originalColor;
        }
    }
}
