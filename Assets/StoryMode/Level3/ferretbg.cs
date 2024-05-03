using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerretBG : MonoBehaviour
{
    [SerializeField]
    private float gametime;
    bool endLogic;
    // Update is called once per frame
    void Update()
    {
        if (gametime > 0)
        {
            gametime -= Time.deltaTime;
            transform.position = new Vector3(transform.position.x, 10 - (30 / gametime * 2));
        }
        else if (endLogic == false)
        {
            GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().Level = 4;
            GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().watchCutscene = true;
            if (SaveData.storyLevel < 4)
            {
                SaveData.storyLevel = 4;
                SaveData.Save();
            }
            GameObject.Find("Main Camera").GetComponent<SceneChange>().Transition("Cutscenes");
            endLogic = true;
        }
    }
}
