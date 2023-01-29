using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordRichPresence;

public class SetDiscordStatus : MonoBehaviour
{
    public bool onAwake;
    public string SetDetails;
    public string SetStatus;
    Status discord;
    // Start is called before the first frame update
    void Start()
    {
        discord = GameObject.Find("Discordo").GetComponent<Status>();
        if (onAwake)
        {
            UpdateStatus();
        }
    }

    public void UpdateStatus()
    {
        discord.presence.details = SetDetails;
        discord.presence.state = SetStatus;
        DiscordRpc.UpdatePresence(ref discord.presence);
    }

    public void UpdateStatus(string details, string status)
    {
        discord.presence.details = details;
        discord.presence.state = status;
        DiscordRpc.UpdatePresence(ref discord.presence);
    }
}
