using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour
{
    public float moveX;
    public float moveY;
    [SerializeField]
    float moveTime;
    [SerializeField]
    AnimationCurve curve;
    public bool relative = true;
    [SerializeField]
    GameObject[] group;
    GameObject player;

    float lerpMultiplier;
    float deltatime;
    float[] camX;
    float[] camY;
    bool set;

    int index;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Mocha");
        lerpMultiplier = 1 / moveTime;
        camX = new float[group.Length];
        camY = new float[group.Length];
        foreach (GameObject obj in group)
        {
            camX[index] = obj.transform.position.x;
            camY[index] = obj.transform.position.y;
            index++;
        }
        index = 0;
        if (player.GetComponent<MochometryDash>().doStartPos && player.GetComponent<MochometryDash>().startPos.x > transform.position.x)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > transform.position.x && deltatime < 1)
        {
            foreach (GameObject cam in group)
            {
                if (!set)
                {
                    camX[index] = cam.transform.position.x;
                    camY[index] = cam.transform.position.y;
                    if (relative)
                    {
                        moveX = camX[index] + moveX;
                        moveY = camY[index] + moveY;
                    }
                    set = true;
                }
                cam.transform.position = new Vector3(Mathf.Lerp(camX[index], moveX, curve.Evaluate(deltatime)), Mathf.Lerp(camY[index], moveY, curve.Evaluate(deltatime)), cam.transform.position.z);
                index++;
            }
            index = 0;
            deltatime += Time.deltaTime * lerpMultiplier;
        }
        if (deltatime >= 1)
        {
            if (!relative)
            {
                foreach (GameObject cam in group)
                {
                    cam.transform.position = new Vector3(moveX, moveY, cam.transform.position.z);
                }
            }
            gameObject.SetActive(false);
        }
    }
}
