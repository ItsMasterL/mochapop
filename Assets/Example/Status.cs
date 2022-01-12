using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordRichPresence;

public class Status : MonoBehaviour
{
    private DiscordRpc.EventHandlers handlers;
    private DiscordRpc.RichPresence presence;
    
    public int popcount;

    public void Start()
    {
        this.handlers = default(DiscordRpc.EventHandlers);
        DiscordRpc.Initialize("930631176195031041", ref this.handlers, true, null);
        this.handlers = default(DiscordRpc.EventHandlers);
        DiscordRpc.Initialize("930631176195031041", ref this.handlers, true, null);
        this.presence.details = "Popping";
        this.presence.state = "0 pops";
        this.presence.largeImageKey = "open";
        this.presence.smallImageKey = "";
        this.presence.largeImageText = "look its mocha pop";
        this.presence.smallImageText = "";
        DiscordRpc.UpdatePresence(ref this.presence);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            popcount += 1;
            this.presence.state = (popcount.ToString() + " pops");
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}