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

    // Start is called before the first frame update
    void Start()
    {
        chaching = GameObject.Find("purchase").GetComponent<AudioSource>();
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

            SaveData.Save();
            gameObject.SetActive(false);
        }
    }
}
