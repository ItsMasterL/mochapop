using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnlockCodes : MonoBehaviour
{
    private string[] codes;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        codes = new string[9];

        codes[0] = "ohnotthatguy"; //Brett's code
        codes[1] = "EXTOCINE"; //Exto's code
        codes[2] = "finderskeepers"; //Deon's code
        codes[3] = "i'mnotafurryguys"; //Syowen's code
        codes[4] = "mightygen"; //Skylar's code
        codes[5] = "FUDGIKAKE"; //Fudgi's code
        codes[6] = "DREAMSICLE"; //Dreamsicle's code
        codes[7] = "waytoomuchhair"; //Arbitrary's code
        codes[8] = "T DIRTY"; //T Dirty's code
    }

    private int Check()
    {
        string input = GetComponent<TMP_InputField>().text.ToLower().Replace(" ", string.Empty);
        foreach(string code in codes)
        {
            if (code == input)
            {
                return index;
            }
            index++;
        }
        //Getting to this point means the code was incorrect
        index = 0;
        return 404;
    }

    public void SubmitCode()
    {
        if (GetComponent<TMP_InputField>().text.ToLower().Replace(" ",string.Empty) != string.Empty)
        {
            int result = Check();
            GetComponent<TMP_InputField>().text = string.Empty;
            if (result != 404)
            {
                GameObject.Find("Achievement").GetComponent<Achievements>().Code(result);
            }
        }
    }
}
