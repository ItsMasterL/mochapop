using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckPlatform : MonoBehaviour
{
    TextMeshProUGUI text;
    public bool DebugAndroidMode;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
        text.text = "Press Space to pop!";

        if (Application.platform == RuntimePlatform.Android || DebugAndroidMode == true)
        {
            text.text = "Tap screen to pop!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
