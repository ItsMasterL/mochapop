using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScollAchievements : MonoBehaviour
{
    public GameObject[] achievements;
    private float multiplier;
    private float[] offset;
    private int index;

    private void Start()
    {
        offset = new float[achievements.Length];
        foreach(GameObject obj in achievements)
        {
            offset[index] = obj.GetComponent<RectTransform>().anchoredPosition.y;
            index++;
        }
        index = 0;
        multiplier = achievements.Length + 1;
    }

    public void Scroll()
    {
        foreach(GameObject obj in achievements)
        {
            RectTransform rect = obj.GetComponent<RectTransform>();
            rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, offset[index] + (GetComponent<Scrollbar>().value * multiplier));
            index++;
        }
        index = 0;
    }
}
