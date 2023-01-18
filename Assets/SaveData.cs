using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static bool unlockTimer;
    public static bool unlockSpeed;
    public static bool unlockRGB;
    public static bool unlockSilence;
    public static bool unlockBank;

    public static bool achievement1;
    public static bool achievement2;
    public static bool achievement3;
    
    public static int costume;
    
    void Awake()
    {
        Load();
    }

    public static void Load()
    {
        Debug.Log("Loading");
        if (PlayerPrefs.HasKey("uTimer"))
        {
            unlockTimer = PlayerPrefs.GetInt("uTimer") == 1 ? true : false;
            unlockSpeed = PlayerPrefs.GetInt("uSpeed") == 1 ? true : false;
            unlockRGB = PlayerPrefs.GetInt("uRGB") == 1 ? true : false;
            unlockSilence = PlayerPrefs.GetInt("uSilence") == 1 ? true : false;
            unlockBank = PlayerPrefs.GetInt("uBank") == 1 ? true : false;

            achievement1 = PlayerPrefs.GetInt("a1") == 1 ? true : false;
            achievement2 = PlayerPrefs.GetInt("a2") == 1 ? true : false;
            achievement3 = PlayerPrefs.GetInt("a3") == 1 ? true : false;

            costume = PlayerPrefs.GetInt("costume");
        }

        Debug.Log(achievement3);
    }

    public static void Reset()
    {
        PlayerPrefs.SetInt("uTimer", 0);
        PlayerPrefs.SetInt("uSpeed", 0);
        PlayerPrefs.SetInt("uRGB", 0);
        PlayerPrefs.SetInt("uSilence", 0);
        PlayerPrefs.SetInt("uBank", 0);

        achievement1 = false;
        achievement2 = false;
        achievement3 = false;
        PlayerPrefs.SetInt("a1", 0);
        PlayerPrefs.SetInt("a2", 0);
        PlayerPrefs.SetInt("a3", 0);

        PlayerPrefs.SetInt("costume", 0);

        PlayerPrefs.Save();
        Load();
        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
    }

    public static void Load(int id, GameObject obj)
    {
        switch(id)
        {
            case 0:
                if (unlockTimer)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                break;
            case 1:
                if (unlockSpeed)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                break;
            case 2:
                if (unlockRGB)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                break;
            case 3:
                if (unlockSilence)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                break;
        }
    }

    public static void Purchased(int id)
    {
        switch (id)
        {
            case 0:
                unlockTimer = true;
                break;
            case 1:
                unlockSpeed = true;
                break;
            case 2:
                unlockRGB = true;
                break;
            case 3:
                unlockSilence = true;
                break;
            case 4:
                unlockBank = true;
                break;
        }
    }

    public static void Achieved(int id)
    {
        switch (id)
        {
            case 1:
                achievement1 = true;
                break;
            case 2:
                achievement2 = true;
                break;
            case 3:
                achievement3 = true;
                break;
        }
    }
    
    public static void Save()
    {
        PlayerPrefs.SetInt("uTimer", unlockTimer ? 1 : 0);
        PlayerPrefs.SetInt("uSpeed", unlockSpeed ? 1 : 0);
        PlayerPrefs.SetInt("uRGB", unlockRGB ? 1 : 0);
        PlayerPrefs.SetInt("uSilence", unlockSilence ? 1 : 0);
        PlayerPrefs.SetInt("uBank", unlockBank ? 1 : 0);

        PlayerPrefs.SetInt("a1", achievement1 ? 1 : 0);
        PlayerPrefs.SetInt("a2", achievement2 ? 1 : 0);
        PlayerPrefs.SetInt("a3", achievement3 ? 1 : 0);

        PlayerPrefs.SetInt("costume", costume);

        PlayerPrefs.Save();
    }
}
