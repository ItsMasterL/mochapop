using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneDialogue : MonoBehaviour
{
    TMPro.TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GameObject.Find("Dialogue").GetComponent<TMPro.TextMeshProUGUI>();
    }

    public void SetDialogue(string words)
    {
        tmp.text = words;
    }
}
