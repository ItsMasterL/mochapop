using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
   public void Achievement(int id)
    {
        GetComponent<TextRGB>().alpha = 5;
        GetComponent<AudioSource>().Play();
        GetComponentInChildren<AchievementSubtext>().Info(id, false);
        SaveData.Achieved(id);
        SaveData.Save();
    }

    public void Code(int id)
    {
        GetComponent<TextRGB>().alpha = 5;
        GetComponent<AudioSource>().Play();
        GetComponentInChildren<AchievementSubtext>().Info(id, true);
        SaveData.Unlocked(id + 1);
        SaveData.Save();
    }
}
