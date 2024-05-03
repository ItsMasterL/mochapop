using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boop : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !SaveData.achievement1)
        {
            int layer_mask = LayerMask.GetMask("Snout");
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            RaycastHit2D hitInfo = Physics2D.Raycast(mousePos, Vector2.zero, 100000, layer_mask);

            if (hitInfo.collider != null && hitInfo.collider.CompareTag("Snout"))
            {
                GameObject.Find("Achievement").GetComponent<Achievements>().Achievement(1);
                if (SaveData.costume == 0)
                    GameObject.Find("Mocha").GetComponent<Pop>().Costume(1);
            }
        }
    }
}
