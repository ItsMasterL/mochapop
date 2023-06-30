using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public static string nextScene;
    public GameObject transitionObject;
    bool transition;
    Color color;
    GameObject Mocha;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            transitionObject = GameObject.Find("Overlay");
        }
        if (SceneManager.GetActiveScene().name == "StorySelect")
        {
            transitionObject = GameObject.Find("Panel");
        }
        Mocha = GameObject.Find("Mocha");
    }

    public void Transition(string scene)
    {
        if (transitionObject.GetComponent<Image>().color.a <= 0)
        {
            nextScene = scene;
            transition = true;
            SaveData.Save();
        }
    }

    public void SetColor(bool black)
    {
        transitionObject.GetComponent<FadeAlpha>().fadeToBlack = black;
    }

    private void Update()
    {
        if (transition == true)
        {
            if (Mocha != null)
            {
                Mocha.GetComponent<Pop>().canPop = false;
            }
            color = transitionObject.GetComponent<Image>().color;
            color.a += Time.deltaTime;
            transitionObject.GetComponent<Image>().color = color;

            if (color.a >= 1)
            {
                transition = false;
                if (nextScene == "Cutscenes")
                {
                    GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().watchCutscene = true;
                }
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
