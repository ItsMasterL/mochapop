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
        }
    }
}
