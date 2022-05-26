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
            RaycastHit2D hitInfo = new RaycastHit2D();
            int layer_mask = LayerMask.GetMask("Snout");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            hitInfo = Physics2D.Raycast(mousePos2D, Vector2.zero, 100000, layer_mask);

            if (hitInfo.collider.tag == "Snout")
            {
                GameObject.Find("Achievement").GetComponent<Achievement>().alpha = 5;
                GameObject.Find("Achievement").GetComponent<AudioSource>().Play();
                SaveData.Achieved(1);
                SaveData.Save();
            }
        }
    }
}
