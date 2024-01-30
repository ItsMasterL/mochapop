using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenItem : MonoBehaviour
{
    [SerializeField]
    int weight;

    GameObject ferret;
    float randWeight;
    public float delay;
    int index;
    float timer;
    bool isFalling;
    bool canFall;
    GameObject[] otherItems;
    // Start is called before the first frame update
    void Start()
    {
        otherItems = new GameObject[GameObject.FindObjectsOfType<FallenItem>().Length];
        ferret = GameObject.Find("Ferret");
        foreach (GameObject obj in otherItems)
        {
            if (obj == null && GameObject.FindObjectsOfType<FallenItem>()[index].gameObject != this.gameObject)
            {
                otherItems[index] = GameObject.FindObjectsOfType<FallenItem>()[index].gameObject;
            }
            index++;
        }
        timer = Random.Range(0.25f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (ferret.transform.position.y > 7)
        {
            timer -= Time.deltaTime;
            if (timer <= 0 && isFalling == false)
            {
                randWeight = Random.Range(weight - 1.5f, weight + 1.5f);
                canFall = true;
                foreach (GameObject obj in otherItems)
                {
                    if (obj != null)
                        if (obj.GetComponent<FallenItem>().delay < 0.5f && obj.GetComponent<FallenItem>().delay > 0)
                        {
                            canFall = false;
                            timer = Random.Range(0.25f, 4f);
                        }
                }
                if (canFall)
                {
                    isFalling = true;
                }
            }
            if (isFalling)
            {
                delay += Time.deltaTime;
                transform.position = new Vector3(transform.position.x, transform.position.y - (randWeight + delay) * Time.deltaTime);
                if (transform.position.y < -10)
                {
                    transform.position = new Vector3(transform.position.x, 7);
                    isFalling = false;
                    timer = Random.Range(0.25f, 4f);
                    delay = 0;
                }
            }
        }
    }
}
