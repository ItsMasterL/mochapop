using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetStoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.MoveGameObjectToScene(GameObject.Find("StoryModeManager"), SceneManager.GetActiveScene());
    }
}
