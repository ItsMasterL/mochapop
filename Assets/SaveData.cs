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
    public static bool unlockStory;

    public static int storyLevel;

    public static bool achievement1;
    public static bool achievement2;
    public static bool achievement3;

    public static bool code1;
    public static bool code2;
    public static bool code3;
    public static bool code4;
    public static bool code5;
    public static bool code6;
    public static bool code7;
    public static bool code8;
    public static bool code9;
    
    public static int costume;
    public static int savedPops;

    public static bool defaultRGB;

    public List<GameObject> shops;
    public static List<GameObject> staticshops;
    
    void Awake()
    {
        Load();
        DontDestroyOnLoad(gameObject);
        staticshops = shops;
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
            unlockStory = PlayerPrefs.GetInt("uStory") == 1 ? true : false;

            storyLevel = PlayerPrefs.GetInt("sLevel");

            achievement1 = PlayerPrefs.GetInt("a1") == 1 ? true : false;
            achievement2 = PlayerPrefs.GetInt("a2") == 1 ? true : false;
            achievement3 = PlayerPrefs.GetInt("a3") == 1 ? true : false;

            code1 = PlayerPrefs.GetInt("c1") == 1 ? true : false;
            code2 = PlayerPrefs.GetInt("c2") == 1 ? true : false;
            code3 = PlayerPrefs.GetInt("c3") == 1 ? true : false;
            code4 = PlayerPrefs.GetInt("c4") == 1 ? true : false;
            code5 = PlayerPrefs.GetInt("c5") == 1 ? true : false;
            code6 = PlayerPrefs.GetInt("c6") == 1 ? true : false;
            code7 = PlayerPrefs.GetInt("c7") == 1 ? true : false;
            code8 = PlayerPrefs.GetInt("c8") == 1 ? true : false;
            code9 = PlayerPrefs.GetInt("c9") == 1 ? true : false;

            costume = PlayerPrefs.GetInt("costume");
            savedPops = PlayerPrefs.GetInt("pops");

            defaultRGB = PlayerPrefs.GetInt("dRGB") == 1 ? true : false;
        }

        Debug.Log(achievement3);
    }
    public static void ResetData()
    {
        Pop.popcount = 0;

        PlayerPrefs.SetInt("uTimer", 0);
        PlayerPrefs.SetInt("uSpeed", 0);
        PlayerPrefs.SetInt("uRGB", 0);
        PlayerPrefs.SetInt("uSilence", 0);
        PlayerPrefs.SetInt("uBank", 0);
        PlayerPrefs.SetInt("uStory", 0);

        PlayerPrefs.SetInt("sLevel", 0);

        achievement1 = false;
        achievement2 = false;
        achievement3 = false;
        PlayerPrefs.SetInt("a1", 0);
        PlayerPrefs.SetInt("a2", 0);
        PlayerPrefs.SetInt("a3", 0);
        code1 = false;
        code2 = false;
        code3 = false;
        code4 = false;
        code5 = false;
        code6 = false;
        code7 = false;
        code8 = false;
        code9 = false;
        PlayerPrefs.SetInt("c1", 0);
        PlayerPrefs.SetInt("c2", 0);
        PlayerPrefs.SetInt("c3", 0);
        PlayerPrefs.SetInt("c4", 0);
        PlayerPrefs.SetInt("c5", 0);
        PlayerPrefs.SetInt("c6", 0);
        PlayerPrefs.SetInt("c7", 0);
        PlayerPrefs.SetInt("c8", 0);
        PlayerPrefs.SetInt("c9", 0);

        PlayerPrefs.SetInt("costume", 0);
        PlayerPrefs.SetInt("pops", 0);

        PlayerPrefs.SetInt("dRGB", 0);

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
                } else
                {
                    obj.GetComponent<Buy>().purchased = false;
                }
                break;
            case 1:
                if (unlockSpeed)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                else
                {
                    obj.GetComponent<Buy>().purchased = false;
                }
                break;
            case 2:
                if (unlockRGB)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                else
                {
                    obj.GetComponent<Buy>().purchased = false;
                }
                break;
            case 3:
                if (unlockSilence)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                else
                {
                    obj.GetComponent<Buy>().purchased = false;
                }
                break;
            case 4:
                if (unlockBank)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                else
                {
                    obj.GetComponent<Buy>().purchased = false;
                }
                break;
            case 5:
                if (unlockStory)
                {
                    obj.GetComponent<Buy>().purchased = true;
                }
                else
                {
                    obj.GetComponent<Buy>().purchased = false;
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
            case 5:
                unlockStory = true;
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

    public static void Unlocked(int id)
    {
        switch (id)
        {
            case 1:
                code1 = true;
                break;
            case 2:
                code2 = true;
                break;
            case 3:
                code3 = true;
                break;
            case 4:
                code4 = true;
                break;
            case 5:
                code5 = true;
                break;
            case 6:
                code6 = true;
                break;
            case 7:
                code7 = true;
                break;
            case 8:
                code8 = true;
                break;
            case 9:
                code9 = true;
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
        PlayerPrefs.SetInt("uStory", unlockStory ? 1 : 0);

        PlayerPrefs.SetInt("sLevel", storyLevel);

        PlayerPrefs.SetInt("a1", achievement1 ? 1 : 0);
        PlayerPrefs.SetInt("a2", achievement2 ? 1 : 0);
        PlayerPrefs.SetInt("a3", achievement3 ? 1 : 0);

        PlayerPrefs.SetInt("c1", code1 ? 1 : 0);
        PlayerPrefs.SetInt("c2", code2 ? 1 : 0);
        PlayerPrefs.SetInt("c3", code3 ? 1 : 0);
        PlayerPrefs.SetInt("c4", code4 ? 1 : 0);
        PlayerPrefs.SetInt("c5", code5 ? 1 : 0);
        PlayerPrefs.SetInt("c6", code6 ? 1 : 0);
        PlayerPrefs.SetInt("c7", code7 ? 1 : 0);
        PlayerPrefs.SetInt("c8", code8 ? 1 : 0);
        PlayerPrefs.SetInt("c9", code9 ? 1 : 0);

        PlayerPrefs.SetInt("costume", costume);
        PlayerPrefs.SetInt("pops", savedPops);

        PlayerPrefs.SetInt("dRGB", defaultRGB ? 1 : 0);

        PlayerPrefs.Save();
    }

    public static void Save(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
        PlayerPrefs.Save();
    }

    public static void Save(string key, bool value)
    {
        PlayerPrefs.SetInt(key, value ? 1 : 0);
        PlayerPrefs.Save();
    }
}
