using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopToWait : MonoBehaviour
{
    Pop pop;
    public float forwardSpeed;
    public float backwardSpeed;
    bool moveback = true;
    float initX;
    BoxCollider2D collision;
    SlideToTheLeft slide;

    // Start is called before the first frame update
    void Start()
    {
        pop = GetComponent<Pop>();
        initX = transform.position.x;
        collision = GetComponent<BoxCollider2D>();
        slide = GetComponent<SlideToTheLeft>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collision.enabled == false)
        {
            transform.localScale = new Vector3(transform.localScale.x, 0.02f, transform.localScale.z);
            transform.position = new Vector3(transform.position.x, -4, transform.position.z);
            slide.enabled = true;
            pop.canPop = false;
            if (transform.position.x < -15) SceneManager.LoadScene("PatientCroc");
            return;
        }
        if (pop.canPop == true)
        {

            if (Input.GetKeyDown(KeyCode.Space) || (pop.isAndroid == true && Input.GetMouseButtonDown(0)))
            {
                moveback = false;
            }

            if (Input.GetKeyUp(KeyCode.Space) || (pop.isAndroid == true && Input.GetMouseButtonUp(0)))
            {
                moveback = true;
            }
        }

        if (moveback && transform.position.x < initX)
        {
            transform.position = new Vector3(transform.position.x + forwardSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else if (!moveback)
        {
            transform.position = new Vector3(transform.position.x - backwardSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.collision.enabled = false;
    }
}
