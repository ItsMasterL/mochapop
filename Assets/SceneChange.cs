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
    }

    public void Transition(string scene)
    {
        if (transitionObject.GetComponent<Image>().color.a <= 0)
        {
            if (GameObject.Find("Mocha") != null)
            {
                GameObject.Find("Mocha").GetComponent<Pop>().canPop = false;
            }
            nextScene = scene;
            transition = true;
            SaveData.Save();
        }
    }

    private void Update()
    {
        if (transition == true)
        {
            color = transitionObject.GetComponent<Image>().color;
            color.a += Time.deltaTime;
            transitionObject.GetComponent<Image>().color = color;

            if (color.a >= 1)
            {
                transition = false;
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
