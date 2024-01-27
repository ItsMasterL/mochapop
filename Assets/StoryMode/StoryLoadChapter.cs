using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryLoadChapter : MonoBehaviour
{
    [SerializeField]
    private int id;
    [SerializeField]
    private string lvlname;
    private bool skipCutscene;

    private Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        if (SaveData.storyLevel >= id)
        {
            btn.interactable = true;
            gameObject.GetComponentInChildren<TextMeshProUGUI>().text = lvlname;
        }
        if (SaveData.storyLevel > id)
        {
            skipCutscene = true;
        }
    }

    public void Clicky()
    {
        DontDestroyOnLoad(GameObject.Find("StoryModeManager"));
        GameObject.Find("StoryModeManager").GetComponent<StoryModeManager>().Level = id;
        GameObject.Find("Panel").GetComponent<SceneChange>().SetColor(true);
        GameObject.Find("Panel").GetComponent<SceneChange>().Transition(skipCutscene ? lvlname.Replace(" ", string.Empty) : "Cutscenes");
    }
}
