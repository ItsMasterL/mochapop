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

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        if (Application.platform == RuntimePlatform.Android)
        {
            isAndroid = true;
        }
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
                if (makesNoise) anim.Play("pop");
                pop.Play();
                popcount += 1;
                if (Events.GetComponent<TenTimer>().isActive == true)
                {
                    Events.GetComponent<TenTimer>().popcounttimed += 1;
                }
                if (Events.GetComponent<SpeedTimer>().isActive == true)
                {
                    Events.GetComponent<SpeedTimer>().popcounted += 1;
                }
            }

            if (Input.GetKeyUp(KeyCode.Space) || (isAndroid == true && Input.GetMouseButtonUp(0)))
            {
                if (makesNoise) anim.Play("not pop");
                unpop.Play();
            }
        }

        if (canPop == false && anim.GetCurrentAnimatorStateInfo(0).IsName("pop"))
        {
            if (makesNoise) anim.Play("not pop");
            unpop.Play();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
