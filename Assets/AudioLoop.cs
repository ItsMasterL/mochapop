using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoop : MonoBehaviour
{
    public float loopPoint;
    public float endTime;
    public bool testLoop;
    AudioSource src;

    private void Awake()
    {
        src = GetComponent<AudioSource>();
        if (testLoop) src.time = endTime - 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (src.time > endTime)
        {
            src.time -= endTime - loopPoint;
        }
    }
}
