using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPurchased : MonoBehaviour
{
    public List<GameObject> purchases;
    public int e = 0;

    // Update is called once per frame
    void Update()
    {
        if (!SaveData.achievement3)
        {
            e = 0;
            foreach(GameObject obj in purchases)
            {
                if (obj.GetComponent<Buy>().purchased == true)
                {
                    e += 1;
                }
            }
            if (e == purchases.Count)
            {
                GameObject.Find("Achievement").GetComponent<TextRGB>().alpha = 5;
                GameObject.Find("Achievement").GetComponent<AudioSource>().Play();
                SaveData.Achieved(3);
                SaveData.Save();
            }
        }
    }
}
