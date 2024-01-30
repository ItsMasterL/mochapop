using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    public Animator anim;
    public AudioSource pop;
    public AudioSource unpop;
    public int debugPopcount = 0;
    public static int popcount = 0;
    public bool canPop = true;
    public bool AI = false;
    public bool makesNoise = true;
    public bool noiseVariation = true;
    public bool isAndroid = false;
    public bool isPopping;
    public bool isCutscene = false;

    public GameObject Events;
    public GameObject Discord;

    public RectTransform boopZone;

    //Expressions
    [SerializeField]
    string popOpen = "pop";
    [SerializeField]
    string popClose = "not pop";
    [SerializeField]
    string sad = "sad";

    float autopoptime;

    // Use this for initialization
    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        if (!AI)
        {
            Discord = GameObject.Find("Discordo");
            debugPopcount = 0;
            if (Application.platform == RuntimePlatform.Android)
            {
                isAndroid = true;
            }
            Costume(SaveData.costume);

            if (SaveData.unlockBank) popcount = SaveData.savedPops;
        }

        anim.Play(popClose);
    }

    public void CostumeNoSave(int index)
    {
        switch (index)
        {
            default:
                popOpen = "pop";
                popClose = "not pop";
                sad = "sad";
                break;
            case 1:
                popOpen = "popBlush";
                popClose = "not popBlush";
                sad = "sadBlush";
                break;
            case 2:
                popOpen = "popCool";
                popClose = "not popCool";
                sad = "sadCool";
                break;
            case 3:
                popOpen = "popBeta";
                popClose = "not popBeta";
                sad = "sadBeta";
                break;
            case 4:
                popOpen = "popGamerBird";
                popClose = "not popGamerBird";
                sad = "sadGamerBird";
                break;
            case 5:
                popOpen = "popPatientCroc";
                popClose = "not popPatientCroc";
                sad = "sadPatientCroc";
                break;
            case 6:
                popOpen = "popClumsyFerret";
                popClose = "not popClumsyFerret";
                sad = "sadClumsyFerret";
                break;
        }
        anim.Play(popClose);
        GetComponent<Vocals>().SetCharacter(index - 4);
    }

    public void Costume(int index)
    {
        switch (index)
        {
            default:
                popOpen = "pop";
                popClose = "not pop";
                sad = "sad";
                break;
            case 1:
                popOpen = "popBlush";
                popClose = "not popBlush";
                sad = "sadBlush";
                break;
            case 2:
                popOpen = "popCool";
                popClose = "not popCool";
                sad = "sadCool";
                break;
            case 3:
                popOpen = "popBeta";
                popClose = "not popBeta";
                sad = "sadBeta";
                break;
            case 4:
                popOpen = "popGamerBird";
                popClose = "not popGamerBird";
                sad = "sadGamerBird";
                break;
            case 5:
                popOpen = "popPatientCroc";
                popClose = "not popPatientCroc";
                sad = "sadPatientCroc";
                break;
        }
        SaveData.costume = index;
        if (!isAndroid && Discord != null) Discord.GetComponent<Status>().changeImage(index);
        SaveData.Save();
        anim.Play(popClose);
    }

    public void SetPlayerVoice()
    {
        GetComponent<Vocals>().SetCharacter(SaveData.costume - 4);
    }

    public void SetPops(bool CanPop)
    {
        canPop = CanPop;
    }

    public void popSounds()
    {
        makesNoise = !makesNoise;
    }

    public void SetExpression(int value)
    {
        switch (value)
        {
            default:
                anim.Play(popClose);
                break;
            case 1:
                anim.Play(popOpen);
                break;
            case 2:
                anim.Play(sad);
                break;
        }
    }

    //Japanese phonetics:
    //0 - a
    //1 - i
    //2 - u
    //3 - e
    //4 - o
    public void Speak(int sound)
    {
        Debug.Log(transform.GetChild(sound).name);
        if (noiseVariation) transform.GetChild(sound).GetComponent<AudioSource>().pitch = Random.Range(0.95f, 1.05f);
        transform.GetChild(sound).GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (autopoptime > 0)
        {
            autopoptime -= Time.deltaTime;
        }
        else if (autopoptime < 0)
        {
            autopoptime = 0;
            ClosePop();
        }
        if (debugPopcount != 0)
        {
            popcount += debugPopcount;
            debugPopcount = 0;
        }
        if (canPop == true) {

            if (Input.GetKeyDown(KeyCode.Space) || (isAndroid == true && Input.GetMouseButtonDown(0)))
            {
                OpenPop();
            }

            if (Input.GetKeyUp(KeyCode.Space) || (isAndroid == true && Input.GetMouseButtonUp(0)))
            {
                ClosePop();
            }
        }

        if (canPop == false && anim.GetCurrentAnimatorStateInfo(0).IsName(popOpen) && isCutscene == false)
        {
            ClosePop();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        //Top Popper 5K
        if (popcount == 5000 && !SaveData.achievement2)
        {
            GameObject.Find("Achievement").GetComponent<Achievements>().Achievement(2);
        }

        
    }
    public void OpenPop()
    {
        isPopping = true;
        anim.Play(popOpen);
        if (noiseVariation)
        {
            pop.pitch = Random.Range(0.95f, 1.05f);
        }
        else
        {
            pop.pitch = 1;
        }
        if (makesNoise) pop.Play();
        popcount += 1;
        if (SaveData.unlockBank)
        {
            SaveData.savedPops = popcount;
            SaveData.Save("pops", SaveData.savedPops);
        }
        if (Events != null)
        {
            if (Events.GetComponent<TenTimer>().isActive == true)
            {
                Events.GetComponent<TenTimer>().popcounttimed += 1;
            }
            if (Events.GetComponent<SpeedTimer>().isActive == true)
            {
                Events.GetComponent<SpeedTimer>().popcounted += 1;
            }
        }
        if (boopZone != null)
        {
            Debug.Log(boopZone.transform.localPosition);
            boopZone.anchoredPosition = new Vector3(10.5f, 6.03f, 0);
        }
    }
    public void OpenPop(float time)
    {
        isPopping = true;
        autopoptime = time;
        anim.Play(popOpen);
        if (noiseVariation)
        {
            pop.pitch = Random.Range(0.95f, 1.05f);
        }
        else
        {
            pop.pitch = 1;
        }
        if (makesNoise) pop.Play();
        popcount += 1;
    }

    public void ClosePop()
    {
        if (autopoptime == 0)
        {
            isPopping = false;
            anim.Play(popClose);
            if (makesNoise) unpop.Play();
            if (boopZone != null) boopZone.anchoredPosition = new Vector3(10.8f, 3.63f, 0);
        }
    }
}
