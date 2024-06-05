using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AchievementSubtext : MonoBehaviour
{
    TextMeshProUGUI tmp;
    string[] achievementNames;
    string[] codeNames;

    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
        achievementNames = new string[13];
        achievementNames[0] = "A Furry Thing to do";
        achievementNames[1] = "Top Popper 5K";
        achievementNames[2] = "Am Monopoly !!1!";
        achievementNames[3] = "The Story Begins";
        achievementNames[4] = "Keeping your cool";
        achievementNames[5] = "Accepting Setbacks";
        achievementNames[6] = "Staying Playful";
        achievementNames[7] = "Keep a steady pace";
        achievementNames[8] = "No risk, no reward";
        achievementNames[9] = "Keeping it together";
        achievementNames[10] = "Take your time";
        achievementNames[11] = "Take time to relax";
        achievementNames[12] = "Overcome";

        codeNames = new string[9];
        codeNames[0] = "It's that guy";
        codeNames[1] = "PLACEHOLDER";
        codeNames[2] = "Losers Pay Retail";
        codeNames[3] = "He's really not";
        codeNames[4] = "PLACEHOLDER";
        codeNames[5] = "Slayer of Beasts";
        codeNames[6] = "PLACEHOLDER";
        codeNames[7] = "Bushy Hair?";
        codeNames[8] = "PLACEHOLDER";
    }

    public void Info(int id, bool isCode)
    {
        if (isCode)
        {
            tmp.text = codeNames[id];
            Debug.Log("Unlocked achievement: " + tmp.text);
        }
        else
        {
            tmp.text = achievementNames[id];
            Debug.Log("Unlocked achievement: " + tmp.text);
        }
    }

    void Update()
    {
        tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, GetComponentInParent<TextRGB>().alpha);
    }
}
