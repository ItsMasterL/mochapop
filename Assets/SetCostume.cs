using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCostume : MonoBehaviour
{
    public void Set(int index)
    {
        switch (index)
        {
            case 1:
                if (SaveData.achievement1)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 2:
                if (SaveData.achievement2)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 3:
                if (SaveData.achievement3)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 4:
                if (SaveData.storyLevel > 1)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 5:
                if (SaveData.storyLevel > 2)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 6:
                if (SaveData.storyLevel > 3)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 7:
                if (SaveData.storyLevel > 4)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 8:
                if (SaveData.storyLevel > 5)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 9:
                if (SaveData.storyLevel > 6)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 10:
                if (SaveData.storyLevel > 7)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 11:
                if (SaveData.storyLevel > 8)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 12:
                if (SaveData.storyLevel > 9)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 13:
                if (SaveData.storyLevel > 10)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 14:
                if (SaveData.code1)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 15:
                if (SaveData.code2)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 16:
                if (SaveData.code3)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 17:
                if (SaveData.code4)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 18:
                if (SaveData.code5)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 19:
                if (SaveData.code6)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 20:
                if (SaveData.code7)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 21:
                if (SaveData.code8)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
            case 22:
                if (SaveData.code9)
                {
                    if (SaveData.costume != index)
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(index);
                    }
                    else
                    {
                        GameObject.Find("Mocha").GetComponent<Pop>().Costume(0);
                    }
                }
                break;
        }
    }
}
