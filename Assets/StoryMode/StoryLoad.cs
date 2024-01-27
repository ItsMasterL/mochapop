using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryLoad : MonoBehaviour
{
    Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        Debug.Log(SaveData.storyLevel);
        if (SaveData.storyLevel != 0)
        {
            btn.interactable = true;
        }
    }
}
