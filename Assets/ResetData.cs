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
            RaycastHit2D hitInfo = new RaycastHit2D();
            int layer_mask = LayerMask.GetMask("Reset");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            hitInfo = Physics2D.Raycast(mousePos2D, Vector2.zero, 100000, layer_mask);
            if (hitInfo.collider != null)
            {
                fivesec -= Time.deltaTime;
            } else
            {
                fivesec = 5;
            }
        }

        if (fivesec <= 0)
        {
            SaveData.Reset();
            GameObject.Find("DataReset").GetComponent<Achievement>().alpha = 5;
            foreach (GameObject i in purchasables)
            {
                GetComponent<Buy>().Undone();
            }
            fivesec = 100000000;
        }
    }
}
