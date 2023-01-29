using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryModeManager : MonoBehaviour
{
    public bool watchCutscene;
    public int Level;
    public string LevelName;
    public float cutsceneLength;
    bool setup;
    
    public void StartButton()
    {
        DontDestroyOnLoad(gameObject);
        watchCutscene = true;
        Level = 0;
    }

    private void Update()
    {
        switch (Level)
        {
            case 0:
                LevelName = "";
                break;
            case 1:
                LevelName = "GamerBird";
                break;
        }

        if (SceneManager.GetActiveScene().name == "Cutscenes" && watchCutscene == true && setup == false)
        {
            //GameObject.Find("Mocha").GetComponent<Pop>().Costume(SaveData.costume);
            switch (Level)
            {
                case 0:
                    Debug.Log("Starting Scene");
                    GameObject.Find("Mocha").GetComponent<Animator>().Play("story_intro",1);
                    GameObject.Find("mochapopTragedy").GetComponent<AudioSource>().Play();
                    cutsceneLength = 22.47f;
                    setup = true;
                    break;
            }
        }

        if (cutsceneLength > 0)
        {
            cutsceneLength -= Time.deltaTime;
        }
        if (cutsceneLength <= 0 && setup == true)
        {
            if (Level == 0)
            {
                Level++;
                GameObject.Find("Panel").GetComponent<SceneChange>().Transition("Cutscenes");
            } else
            {
                if (SceneUtility.GetBuildIndexByScenePath(LevelName) != -1)
                {
                    GameObject.Find("Panel").GetComponent<SceneChange>().Transition(LevelName);
                } else
                {
                    GameObject.Find("Panel").GetComponent<SceneChange>().Transition("StorySelect");
                }
                watchCutscene = false;
            }
        }
    }


}
