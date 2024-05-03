using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordRichPresence;

public class TenTimer : MonoBehaviour
{
    public float beginTime = 3;
    public float countdown = 10;
    public float resultsTime = 3;
    public float popcounttimed = 0;
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
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true && beginTime > 0)
        {
            beginTime -= Time.deltaTime;
            discord.GetComponent<Status>().presence.details = "Popping, but with more stress";
            System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
            int cur_time = (int)(System.DateTime.UtcNow - epochStart).TotalSeconds;
            discord.GetComponent<Status>().presence.endTimestamp = cur_time + 10;
            DiscordRpc.UpdatePresence(ref discord.GetComponent<Status>().presence);
            foreach (GameObject i in disable)
            {
                i.SetActive(false);
            }
        }

        if (isActive == true && beginTime <= 0 && countdown > 0)
        {
            mocha.GetComponent<Pop>().canPop = true;
            countdown -= Time.deltaTime;
        }

        if (isActive == true && countdown <= 0 && resultsTime > 0)
        {
            mocha.GetComponent<Pop>().canPop = false;
            resultsTime -= Time.deltaTime;
        }

        if (isActive == true && resultsTime <= 0)
        {
            mocha.GetComponent<Pop>().canPop = true;
            isActive = false;
            beginTime = 3;
            countdown = 10;
            resultsTime = 3;
            popcounttimed = 0;
            discord.GetComponent<Status>().presence.details = "Popping";
            discord.GetComponent<Status>().presence.endTimestamp = 0;
            DiscordRpc.UpdatePresence(ref discord.GetComponent<Status>().presence);
            foreach (GameObject i in disable)
            {
                i.SetActive(true);
            }
        }
    }
}
