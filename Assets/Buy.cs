using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject mocha;
    bool purchased = false;
    AudioSource chaching;

    public int price;

    public GameObject bought;
    public int purchaseID;

    // Start is called before the first frame update
    void Start()
    {
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
}
