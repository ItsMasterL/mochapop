using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordRichPresence;

public class SpeedTimer : MonoBehaviour
{
    public float beginTime = 3;
    public float count = 0;
    public float resultsTime = 3;
    public float popcounted = 0;
    public bool isActive = false;
    public GameObject mocha;
    public GameObject discord;
    public List<GameObject> disable;

    // Start is called before the first frame update
    public void Initiate()
    {
        if (isActive == false)
        {
            isActive = true;
            mocha.GetComponent<Pop>().canPop = false;
            discord.GetComponent<Status>().presence.details = "Popping, but faster";
            DiscordRpc.UpdatePresence(ref discord.GetComponent<Status>().presence);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true && beginTime > 0)
        {
            beginTime -= Time.deltaTime;
            foreach (GameObject i in disable)
            {
                i.SetActive(false);
            }
        }

        if (isActive == true && beginTime <= 0 && popcounted < 100)
        {
            mocha.GetComponent<Pop>().canPop = true;
            count += Time.deltaTime;
        }

        if (isActive == true && popcounted >= 100 && resultsTime > 0)
        {
            mocha.GetComponent<Pop>().canPop = false;
            resultsTime -= Time.deltaTime;
        }

        if (isActive == true && resultsTime <= 0)
        {
            mocha.GetComponent<Pop>().canPop = true;
            isActive = false;
            beginTime = 3;
            count = 0;
            resultsTime = 3;
            popcounted = 0;
            discord.GetComponent<Status>().presence.details = "Popping";
            DiscordRpc.UpdatePresence(ref discord.GetComponent<Status>().presence);
            foreach (GameObject i in disable)
            {
                i.SetActive(true);
            }
        }
    }
}
