using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject mocha;
    public bool purchased = false;
    AudioSource chaching;

    public int price;

    public GameObject bought;
    public int purchaseID;

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("NotLoading");
        chaching = GameObject.Find("purchase").GetComponent<AudioSource>();
        SaveData.Load(purchaseID, gameObject);
    }
    
    public void Moners()
    {
        if (Pop.popcount >= price && purchased == false)
        {
            Pop.popcount -= price;
            purchased = true;
            chaching.Play();
            bought.gameObject.SetActive(true);
            SaveData.Purchased(purchaseID);
            if (SaveData.unlockBank)
            {
                SaveData.savedPops = Pop.popcount;
                SaveData.Save("pops", SaveData.savedPops);
            }
            SaveData.Save();
            gameObject.SetActive(false);
        }
    }

    public void Undone()
    {
        purchased = false;
        bought.gameObject.SetActive(false);
        gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        SaveData.Load(purchaseID, gameObject);
        if (GameObject.Find("------Shop").GetComponent<SetGroup>().Done)
        {
            if (purchased == true)
            {
                gameObject.SetActive(false);
            }
            else
            {
                bought.SetActive(false);
            }
        }
    }
}
