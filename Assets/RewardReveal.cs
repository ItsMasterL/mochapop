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
        switch (achievementNum)
        {
            case 1:
                if (SaveData.achievement1)
                {
                    text.text = "Reward: Blushy Costume";
                } else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 2:
                if (SaveData.achievement2)
                {
                    text.text = "Reward: Cool Shades";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 3:
                if (SaveData.achievement3)
                {
                    text.text = "Reward: Early Colors";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 4:
                if (SaveData.storyLevel > 1)
                {
                    text.text = "Reward: Gamer Bird";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 5:
                if (SaveData.storyLevel > 2)
                {
                    text.text = "Reward: Patient Croc";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 6:
                if (SaveData.storyLevel > 3)
                {
                    text.text = "Reward: Clumsy Ferret";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 7:
                if (SaveData.storyLevel > 4)
                {
                    text.text = "Reward: Slick Brick";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 8:
                if (SaveData.storyLevel > 5)
                {
                    text.text = "Reward: DJ Capybara";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 9:
                if (SaveData.storyLevel > 6)
                {
                    text.text = "Reward: Very Safe Wolf";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 10:
                if (SaveData.storyLevel > 7)
                {
                    text.text = "Reward: Manic Raccoon";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 11:
                if (SaveData.storyLevel > 8)
                {
                    text.text = "Reward: Quite Precise Pile of Debris";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 12:
                if (SaveData.storyLevel > 9)
                {
                    text.text = "Reward: Drowsy Hedgehog";
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 13:
                if (SaveData.storyLevel > 10)
                {
                    text.text = "Reward: More Mature Mocha"; //Long hair
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 14:
                if (SaveData.code1)
                {
                    text.text = "Reward: Switch Port Mocha"; //Brett's Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 15:
                if (SaveData.code2)
                {
                    text.text = "Reward: Extocine"; //Exto's Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 16:
                if (SaveData.code3)
                {
                    text.text = "Reward: Deon"; //Deon's Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 17:
                if (SaveData.code4)
                {
                    text.text = "Reward: Syowen"; //Syowen's Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 18:
                if (SaveData.code5)
                {
                    text.text = "Reward: Buneria"; //DJ Capybara's VA Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 19:
                if (SaveData.code6)
                {
                    text.text = "Reward: Fudgi"; //Fudgikake's Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 20:
                if (SaveData.code7)
                {
                    text.text = "Reward: Foxxicle"; //Dreamsicle's Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 21:
                if (SaveData.code8)
                {
                    text.text = "Reward: Super Bushy Man"; //Arbitrary's Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
            case 22:
                if (SaveData.code9)
                {
                    text.text = "Reward: T Dirty"; //t_dirty's Code
                }
                else
                {
                    text.text = "Reward: ???";
                }
                break;
        }
    }
}
