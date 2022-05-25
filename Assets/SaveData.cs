using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static bool unlockTimer;
    public static bool unlockSpeed;
    public static bool unlockRGB;
    public static bool unlockSilence;

    public static bool achievement1;
    public static bool achievement2;
    public static bool achievement3;

    // Start is called before the first frame update
    void Awake()
    {
        if (PlayerPrefs.HasKey("uTimer"))
        {
            unlockTimer = PlayerPrefs.GetInt("uTimer") == 1 ? true : false;
            unlockSpeed = PlayerPrefs.GetInt("uSpeed") == 1 ? true : false;
            unlockRGB = PlayerPrefs.GetInt("uRGB") == 1 ? true : false;
            unlockSilence = PlayerPrefs.GetInt("uSilence") == 1 ? true : false;

            achievement1 = PlayerPrefs.GetInt("a1") == 1 ? true : false;
            achievement2 = PlayerPrefs.GetInt("a2") == 1 ? true : false;
            achievement3 = PlayerPrefs.GetInt("a3") == 1 ? true : false;
        }
    }

    // Update is called once per frame
    public static void Save()
    {
        PlayerPrefs.SetInt("uTimer", unlockTimer ? 1 : 0);
        PlayerPrefs.SetInt("uSpeed", unlockSpeed ? 1 : 0);
        PlayerPrefs.SetInt("uRGB", unlockRGB ? 1 : 0);
        PlayerPrefs.SetInt("uSilence", unlockSilence ? 1 : 0);

        PlayerPrefs.SetInt("a1", achievement1 ? 1 : 0);
        PlayerPrefs.SetInt("a2", achievement2 ? 1 : 0);
        PlayerPrefs.SetInt("a3", achievement3 ? 1 : 0);
        PlayerPrefs.Save();
    }
}
