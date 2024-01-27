using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crocodile : MonoBehaviour
{
    Pop pop;
    float timer;
    float endPop;
    [SerializeField]
    GameObject[] obstacles;
    GameObject lastDrop;
    int max;
    int fallCheck;
    GameObject mocha;
    BoxCollider2D col;
    bool died;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(1f, 10f);
        max = obstacles.Length;
        pop = GetComponent<Pop>();
        endPop = Random.Range(0.2f, 1f);
        mocha = GameObject.Find("Mocha");
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (col.enabled == false)
        {
            if (died == false)
            {
                died = true;
                mocha.GetComponent<AudioSource>().Play();
            }
            transform.localScale = new Vector3(transform.localScale.x, 0.02f, transform.localScale.z);
            transform.position = new Vector3(transform.position.x, 2.47f, transform.position.z);
            pop.isPopping = true;
            pop.canPop = false;
            GetComponent<SlideToTheLeft>().moveSpeed = 2;
            if (transform.position.x < -15)
            {
                GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().Level = 3;
                GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().watchCutscene = true;
                if (SaveData.storyLevel < 3)
                {
                    SaveData.storyLevel = 3;
                    SaveData.Save();
                }
                SceneManager.LoadScene("Cutscenes");
            }
            return;
        }

        timer -= Time.deltaTime;
        if (pop.isPopping == true)
        {
            transform.position = new Vector3(transform.position.x - 2 * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (timer <= 0)
        {
            timer = Random.Range(1, 10);
            lastDrop = null;
            pop.OpenPop(endPop);
            endPop = Random.Range(0.2f, 1f);
            foreach(GameObject obj in obstacles)
            {
                if (obj.GetComponent<FallingObject>().falling) fallCheck++;
            }
            if (fallCheck != max - 1)
            {
                while (lastDrop == null)
                {
                    lastDrop = obstacles[Random.Range(0, max)];
                    if (lastDrop.GetComponent<FallingObject>().falling) lastDrop = null;
                }
                lastDrop.GetComponent<FallingObject>().falling = true;
                lastDrop.transform.position = transform.position;
            }
            else
            {
                Debug.Log("All are falling!");
            }
        }
        fallCheck = 0;
    }
}
