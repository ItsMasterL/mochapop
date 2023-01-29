using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneCheck : MonoBehaviour
{
    GameObject STM;
    private void Start()
    {

        STM = GameObject.Find("StoryModeManager");
        
        if (STM == null)
        {
            Debug.Log("Null!");
            SceneManager.LoadScene("StorySelect");
        }

        if (STM.GetComponent<StoryModeManager>().watchCutscene)
        {
            GetComponent<FadeAlpha>().trigger = true;
        } else
        {
            GetComponent<SceneChange>().Transition(STM.GetComponent<StoryModeManager>().LevelName);
        }
    }
}
