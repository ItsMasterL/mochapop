using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MochaJump : MonoBehaviour
{
    public bool autoJump;
    float autoCooldown;
    public bool hasFatigue;
    public float fatigue = 0.1f;
    float living;
    public List<GameObject> moners;
    GameObject closest;
    bool scoregot;
    public int score = -1;
    bool starko;
    bool naturalDeath;
    // Update is called once per frame
    void Update()
    {
        if (hasFatigue)
        {
            living += Time.deltaTime;
            fatigue = 0.1f * Mathf.Floor(living / 15) + 0.1f;
        }
        if (GetComponent<Pop>().canPop)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (GetComponent<Pop>().isAndroid == true && Input.GetMouseButtonDown(0)))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 8);
            }
        }
        if (transform.position.y < -100 && !autoJump)
        {
            SceneManager.LoadScene("GamerBird");
        }
        if (transform.position.y < -100 && autoJump)
        {
            GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().Level = 2;
            GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().watchCutscene = true;
            if (SaveData.storyLevel < 2)
            {
                SaveData.storyLevel = 2;
                SaveData.Save();
            }
            SceneManager.LoadScene("Cutscenes");
        }
        if (transform.position.y > 7 && !starko && !naturalDeath)
        {
            starko = true;
            foreach (SlideToTheLeft obj in FindObjectsOfType<SlideToTheLeft>())
            {
                obj.enabled = false;
            }
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Pop>().canPop = false;
            gameObject.GetComponent<Rigidbody2D>().constraints = new RigidbodyConstraints2D();
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(6, 20);
            GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
            GetComponent<Renderer>().sortingOrder = -20;
        }

        if (starko && transform.localScale.y > 0.0001f && !naturalDeath)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(4, -3);
            transform.localScale = new Vector3(transform.localScale.x - (0.035f * Time.deltaTime), transform.localScale.y - (0.035f * Time.deltaTime), transform.localScale.z);
            transform.Rotate(new Vector3(0, 0, (360f * Time.deltaTime)));
        }
        float dist = float.PositiveInfinity;
        foreach (GameObject obj in moners)
        {
            var d = (transform.position - obj.transform.position).sqrMagnitude;
            if (d < dist)
            {
                closest = obj;
                dist = d;
            }
        }
        if (transform.position.x >= closest.transform.position.x && !scoregot)
        {
            scoregot = true;
            score++;
        }
        if (transform.position.x < closest.transform.position.x)
        {
            scoregot = false;
        }
        if (autoJump && transform.position.y <= closest.transform.position.y - 0.5 && closest.transform.position.y < 8 && autoCooldown <= 0 && !naturalDeath)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 8);
            autoCooldown += fatigue;
            GetComponent<Pop>().OpenPop(fatigue);
        }
        if (autoJump && transform.position.y <= 0 && closest.transform.position.y > 8 && autoCooldown <= 0 && !naturalDeath)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 8);
            autoCooldown += fatigue;
            GetComponent<Pop>().OpenPop(fatigue);
        }
        if (autoCooldown > 0)
        {
            autoCooldown -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Snout")
        {
            foreach(SlideToTheLeft obj in FindObjectsOfType<SlideToTheLeft>())
            {
                obj.enabled = false;
            }
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Pop>().canPop = false;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 16);
            GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
            naturalDeath = true;
            if (gameObject.name != "Mocha")
            {
                GameObject.Find("Mocha").GetComponent<MochaJump>().autoJump = true;
                GameObject.Find("Mocha").GetComponent<MochaJump>().living = 0;
            }
            GetComponent<AudioSource>().Play();
        }
    }
}
