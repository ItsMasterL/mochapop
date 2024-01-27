using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vocals : MonoBehaviour
{
    public AudioClip[] vowels;

    public void SetCharacter(int id)
    {
        if (id < 0 || id > 9) id = 9;
        transform.GetChild(0).GetComponent<AudioSource>().clip = vowels[(5 * id) + 0];
        transform.GetChild(1).GetComponent<AudioSource>().clip = vowels[(5 * id) + 1];
        transform.GetChild(2).GetComponent<AudioSource>().clip = vowels[(5 * id) + 2];
        transform.GetChild(3).GetComponent<AudioSource>().clip = vowels[(5 * id) + 3];
        transform.GetChild(4).GetComponent<AudioSource>().clip = vowels[(5 * id) + 4];
    }
}
