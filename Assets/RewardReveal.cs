using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RewardReveal : MonoBehaviour
{
    public int achievementNum;

    TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (achievementNum) // TODO: Save this mess
        {
            case 1:
                text.text = SaveData.achievement1 ? "Reward: Blushy Costume" : "Reward: ???";
                break;
            case 2:
                text.text = SaveData.achievement2 ? "Reward: Cool Shades" : "Reward: ???";
                break;
            case 3:
                text.text = SaveData.achievement3 ? "Reward: Early Colors" : "Reward: ???";
                break;
            case 4:
                text.text = SaveData.storyLevel > 1 ? "Reward: Gamer Bird" : "Reward: ???";
                break;
            case 5:
                text.text = SaveData.storyLevel > 2 ? "Reward: Patient Croc" : "Reward: ???";
                break;
            case 6:
                text.text = SaveData.storyLevel > 3 ? "Reward: Clumsy Ferret" : "Reward: ???";
                break;
            case 7:
                text.text = SaveData.storyLevel > 4 ? "Reward: Slick Brick" : "Reward: ???";
                break;
            case 8:
                text.text = SaveData.storyLevel > 5 ? "Reward: DJ Capybara" : "Reward: ???";
                break;
            case 9:
                text.text = SaveData.storyLevel > 6 ? "Reward: Very Safe Wolf" : "Reward: ???";
                break;
            case 10:
                text.text = SaveData.storyLevel > 7 ? "Reward: Manic Raccoon" : "Reward: ???";
                break;
            case 11:
                text.text = SaveData.storyLevel > 8 ? "Reward: Quite Precise Pile of Debris" : "Reward: ???";
                break;
            case 12:
                text.text = SaveData.storyLevel > 9 ? "Reward: Drowsy Hedgehog" : "Reward: ???";
                break;
            case 13:
                text.text = SaveData.storyLevel > 10 ? "Reward: More Mature Mocha" : "Reward: ???"; //Long hair
                break;
            case 14:
                text.text = SaveData.code1 ? "Reward: Switch Port Mocha" : "Reward: ???"; //Brett's Code
                break;
            case 15:
                text.text = SaveData.code2 ? "Reward: Extocine" : "Reward: ???"; //Exto's Code
                break;
            case 16:
                text.text = SaveData.code3 ? "Reward: Deon" : "Reward: ???"; //Deon's Code
                break;
            case 17:
                text.text = SaveData.code4 ? "Reward: Syowen" : "Reward: ???"; //Syowen's Code
                break;
            case 18:
                text.text = SaveData.code5 ? "Reward: Buneria" : "Reward: ???"; //DJ Capybara's VA Code
                break;
            case 19:
                text.text = SaveData.code6 ? "Reward: Fudgi" : "Reward: ???"; //Fudgikake's Code
                break;
            case 20:
                text.text = SaveData.code7 ? "Reward: Foxxicle" : "Reward: ???"; //Dreamsicle's Code
                break;
            case 21:
                text.text = SaveData.code8 ? "Reward: Super Bushy Man" : "Reward: ???"; //Arbitrary's Code
                break;
            case 22:
                text.text = SaveData.code9 ? "Reward: T Dirty" : "Reward: ???"; //t_dirty's Code
                break;
        }
    }
}
