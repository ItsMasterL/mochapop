using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordRichPresence;

public class Status : MonoBehaviour
{
    private DiscordRpc.EventHandlers handlers;
    private DiscordRpc.RichPresence presence;
    
    public int popcount;
    public GameObject mocha;
    public GameObject ten;
    public GameObject Speedy;

    public void Start()
    {
        this.handlers = default(DiscordRpc.EventHandlers);
        DiscordRpc.Initialize("930631176195031041", ref this.handlers, true, null);
        this.handlers = default(DiscordRpc.EventHandlers);
        DiscordRpc.Initialize("930631176195031041", ref this.handlers, true, null);
        this.presence.details = "Popping";
        this.presence.state = "0 pops";
        this.presence.largeImageKey = "closed";
        this.presence.smallImageKey = "";
        this.presence.largeImageText = "look its mocha pop";
        this.presence.smallImageText = "";
        DiscordRpc.UpdatePresence(ref this.presence);
    }

    public void Update()
    {
        popcount = mocha.GetComponent<Pop>().popcount;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.presence.state = (popcount.ToString() + " pops");
            this.presence.largeImageKey = "open";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.presence.largeImageKey = "closed";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        if (Speedy.GetComponent<SpeedTimer>().isActive == true)
        {
            this.presence.details = "Popping, but faster";
        }

        if (ten.GetComponent<TenTimer>().isActive == true)
        {
            this.presence.details = "Popping, but with more stress";
        }

        if (Speedy.GetComponent<SpeedTimer>().isActive == false && ten.GetComponent<TenTimer>().isActive == false)
            {
                this.presence.details = "Popping";
            }
    }
}