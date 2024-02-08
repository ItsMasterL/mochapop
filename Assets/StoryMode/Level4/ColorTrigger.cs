using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTrigger : MonoBehaviour
{
    [SerializeField]
    Color color = new Color(1,1,1,1);
    [SerializeField]
    SpriteRenderer[] colorTargets;
    [SerializeField]
    float changeTime;
    [SerializeField]
    AnimationCurve curve;
    GameObject player;
    Color[] originalColors;
    int index = 0;

    float lerpMultiplier;
    float deltatime;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Mocha");
        lerpMultiplier = 1 / changeTime;
        originalColors = new Color[0];

        if (player.GetComponent<MochometryDash>().doStartPos && player.GetComponent<MochometryDash>().startPos.x > transform.position.x)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > transform.position.x)
        {
            if (changeTime <= 0)
            {
                foreach (SpriteRenderer obj in colorTargets)
                {
                    obj.color = color;
                }
                gameObject.SetActive(false);
            }
            if (originalColors.Length == 0)
            {
                originalColors = new Color[colorTargets.Length];
                foreach (SpriteRenderer obj in colorTargets)
                {
                    originalColors[index] = obj.color;
                    index++;
                }
                index = 0;
            }
            foreach(SpriteRenderer obj in colorTargets)
            {
                Color mod = Color.Lerp(originalColors[index], color, curve.Evaluate(deltatime));
                index++;
                obj.color = mod;
            }
            index = 0;
            deltatime += Time.deltaTime * lerpMultiplier;
        }
        if (deltatime > 1)
        {
            gameObject.SetActive(false);
        }
    }
}
