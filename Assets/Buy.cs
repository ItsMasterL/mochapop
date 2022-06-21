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
        int popcount = mocha.GetComponent<Pop>().popcount;
        if (popcount >= price && purchased == false)
        {
            mocha.GetComponent<Pop>().popcount -= price;
            purchased = true;
            chaching.Play();
            bought.gameObject.SetActive(true);
            SaveData.Purchased(purchaseID);
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
