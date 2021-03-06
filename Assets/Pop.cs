using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    public Animator anim;
    public AudioSource pop;
    public AudioSource unpop;
    public int popcount = 0;
    public bool canPop = true;
    public bool makesNoise = true;
    public bool isAndroid = false;

    public GameObject Events;

    public RectTransform boopZone;

    string popOpen = "pop";
    string popClose = "not pop";

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        if (Application.platform == RuntimePlatform.Android)
        {
            isAndroid = true;
        }
        Costume(SaveData.costume);
    }

    public void Costume(int index)
    {
        switch (index)
        {
            case 0:
                popOpen = "pop";
                popClose = "not pop";
                break;
            case 1:
                popOpen = "popBlush";
                popClose = "not popBlush";
                break;
            case 2:
                popOpen = "popCool";
                popClose = "not popCool";
                break;
            case 3:
                popOpen = "popBeta";
                popClose = "not popBeta";
                break;
        }
        SaveData.costume = index;
        SaveData.Save();
        anim.Play(popClose);
    }

    public void SetPops(bool CanPop)
    {
        canPop = CanPop;
    }

    public void popSounds()
    {
        makesNoise = !makesNoise;
    }

    // Update is called once per frame
    void Update()
    {
        if (canPop == true) {

            if (Input.GetKeyDown(KeyCode.Space) || (isAndroid == true && Input.GetMouseButtonDown(0)))
            {
                anim.Play(popOpen);
                if (makesNoise) pop.Play();
                popcount += 1;
                if (Events.GetComponent<TenTimer>().isActive == true)
                {
                    Events.GetComponent<TenTimer>().popcounttimed += 1;
                }
                if (Events.GetComponent<SpeedTimer>().isActive == true)
                {
                    Events.GetComponent<SpeedTimer>().popcounted += 1;
                }
                Debug.Log(boopZone.transform.localPosition);
                boopZone.anchoredPosition = new Vector3(10.5f, 6.03f, 0);
            }

            if (Input.GetKeyUp(KeyCode.Space) || (isAndroid == true && Input.GetMouseButtonUp(0)))
            {
                anim.Play(popClose);
                if (makesNoise) unpop.Play();
                boopZone.anchoredPosition = new Vector3(10.8f, 3.63f, 0);
            }
        }

        if (canPop == false && anim.GetCurrentAnimatorStateInfo(0).IsName(popOpen))
        {
            anim.Play(popClose);
            if (makesNoise) unpop.Play();
            boopZone.anchoredPosition = new Vector3(10.8f, 3.63f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        //Top Popper 5K
        if (popcount >= 5000 && !SaveData.achievement2)
        {
            GameObject.Find("Achievement").GetComponent<Achievement>().alpha = 5;
            GameObject.Find("Achievement").GetComponent<AudioSource>().Play();
            SaveData.Achieved(2);
            SaveData.Save();
        }
    }
}
