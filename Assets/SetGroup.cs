using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGroup : MonoBehaviour
{
    public string GroupTag;
    public bool StartEnabled = true;
    public List<GameObject> items;
    public bool Done;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (GameObject i in GameObject.FindGameObjectsWithTag(GroupTag))
        {
            items.Add(i);
        }
        Done = true;
        if (!StartEnabled)
        {
            foreach (GameObject i in items)
            {
                i.SetActive(false);
            }
        }
    }

    public void Toggle(bool Enable)
    {
        foreach (GameObject i in items)
        {
            i.SetActive(Enable);
        }
    }
}
