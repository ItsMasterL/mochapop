using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RewardReveal : MonoBehaviour
{
    public int achievementNum;

    TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (achievementNum)
        {
            case 1:
                if (SaveData.achievement1)
                {
                    text.text = "Reward: Blushy Costume";
                }
                break;
            case 2:
                if (SaveData.achievement2)
                {
                    text.text = "Reward: Cool Shades";
                }
                break;
            case 3:
                if (SaveData.achievement3)
                {
                    text.text = "Reward: Early Colors";
                }
                break;
        }
    }
}
