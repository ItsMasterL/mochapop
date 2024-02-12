using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Mocha");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > transform.position.x)
        {
            GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().Level = 5;
            GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().watchCutscene = true;
            if (SaveData.storyLevel < 5)
            {
                SaveData.storyLevel = 5;
                SaveData.Save();
            }
            SceneManager.LoadScene("Cutscenes");
        }
    }
}
