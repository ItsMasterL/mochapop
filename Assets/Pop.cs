using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    public Animator anim;
    public AudioSource pop;
    public AudioSource unpop;
    public int popcount = 0;
    public GUIStyle style;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("pop");
            pop.Play();
            popcount += 1;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.Play("not pop");
            unpop.Play();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), popcount.ToString(), style);
    }
}
