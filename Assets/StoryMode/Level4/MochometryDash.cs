using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MochometryDash : MonoBehaviour
{
    [SerializeField]
    LayerMask groundLayer;
    float deathTimer;
    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Pop>().canPop)
        {
            if ((Input.GetKey(KeyCode.Space) || (GetComponent<Pop>().isAndroid == true && Input.GetMouseButton(0))) && IsGrounded() == true)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,22);
            }
        }
        else
        {
            deathTimer += Time.deltaTime;
        }
        if (deathTimer > 1)
        {
            SceneManager.LoadScene("SlickBrick");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Snout")
        {
            foreach (SlideToTheLeft obj in FindObjectsOfType<SlideToTheLeft>())
            {
                obj.enabled = false;
            }
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Pop>().canPop = false;
            GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("mochapopSlickBrick").GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().Play();
        }
    }
}
