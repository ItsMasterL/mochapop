using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DiscordRichPresence;

public class Status : MonoBehaviour
{
    private DiscordRpc.EventHandlers handlers;
    public DiscordRpc.RichPresence presence;
    
    public int popcount;

    public void Start()
    {
        popcount = Pop.popcount;
        DontDestroyOnLoad(gameObject);
        this.handlers = default(DiscordRpc.EventHandlers);
        DiscordRpc.Initialize("930631176195031041", ref this.handlers, true, null);
        this.handlers = default(DiscordRpc.EventHandlers);
        DiscordRpc.Initialize("930631176195031041", ref this.handlers, true, null);
        this.presence.details = "Popping";
        this.presence.state = popcount.ToString() + " pops";
        this.presence.largeImageKey = "open";
        this.presence.smallImageKey = "";
        this.presence.largeImageText = "look its mocha pop";
        this.presence.smallImageText = "";
        DiscordRpc.UpdatePresence(ref this.presence);
    }

    public void Update()
    {
        popcount = Pop.popcount;

        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.presence.state = ((popcount+1).ToString() + " pops");
                DiscordRpc.UpdatePresence(ref this.presence);
            }
        }
    }

    public void changeImage(int index)
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        switch (index)
        {
            default:
                this.presence.largeImageKey = "open";
                this.presence.largeImageText = "look its mocha pop";
                break;

            case 1:
                this.presence.largeImageKey = "blush";
                this.presence.largeImageText = "what a shy lil guy";
                break;

            case 2:
                this.presence.largeImageKey = "cool";
                this.presence.largeImageText = "bro has epic glasses";
                break;

            case 3:
                this.presence.largeImageKey = "beta";
                this.presence.largeImageText = "old design colors, neato";
                break;
        }
        DiscordRpc.UpdatePresence(ref this.presence);
    }

    public void setTimer(int timestamp)
    {
        this.presence.endTimestamp = timestamp;
    }
}