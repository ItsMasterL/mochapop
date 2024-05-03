using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour
{
    float fivesec = 5;
    public List<GameObject> purchasables;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            int layer_mask = LayerMask.GetMask("Reset");
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            RaycastHit2D hitInfo = Physics2D.Raycast(mousePos, Vector2.zero, 100000, layer_mask);
            if (hitInfo.collider != null)
            {
                fivesec -= Time.deltaTime;
            }
            else
            {
                fivesec = 5;
            }
        }

        if (fivesec <= 0)
        {
            SaveData.ResetData();
            GameObject.Find("DataReset").GetComponent<TextRGB>().alpha = 5;
            foreach (GameObject _ in purchasables)
            {
                GetComponent<Buy>().Undone();
            }
            fivesec = 100000000;
        }
    }
}
