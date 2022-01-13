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

    public GameObject Timer10s;
    public GameObject pop100;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (canPop == true) {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.Play("pop");
                pop.Play();
                popcount += 1;
                if (Timer10s.GetComponent<TenTimer>().isActive == true)
                {
                    Timer10s.GetComponent<TenTimer>().popcounttimed += 1;
                }
                if (pop100.GetComponent<SpeedTimer>().isActive == true)
                {
                    pop100.GetComponent<SpeedTimer>().popcounted += 1;
                }
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                anim.Play("not pop");
                unpop.Play();
            }
        }

        if (canPop == false && anim.GetCurrentAnimatorStateInfo(0).IsName("pop"))
        {
            anim.Play("not pop");
            unpop.Play();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
