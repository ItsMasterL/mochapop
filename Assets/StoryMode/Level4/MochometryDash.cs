using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MochometryDash : MonoBehaviour
{
    [SerializeField]
    LayerMask groundLayer;
    float deathTimer;
    Rigidbody2D rb2;
    SpriteRenderer spr;
    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance;
        if (rb2.gravityScale > 1)
            distance = 1f;
        else
            distance = -1f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    bool IsOrb;
    bool IsGravityOrb;
    bool buffer;
    [SerializeField]
    bool doStartPos;
    [SerializeField]
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        spr = gameObject.GetComponent<SpriteRenderer>();
        if (doStartPos)
        {
            transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);
            GameObject grid = GameObject.Find("Grid");
            grid.transform.position = new Vector3(-startPos.x - 1, grid.transform.position.y, grid.transform.position.z);
            GameObject.Find("mochapopSlickBrick").GetComponent<AudioSource>().time = startPos.x / 10.386f;
            float offsetX = 0;
            float offsetY = 0;
            foreach(MoveTrigger trigger in GameObject.FindObjectsOfType<MoveTrigger>())
            {
                if (trigger.gameObject.transform.position.x < transform.position.x)
                {
                    if (trigger.relative)
                    {
                        offsetX += trigger.moveX;
                        offsetY += trigger.moveY;
                    }
                    else
                    {
                        offsetX = trigger.moveX;
                        offsetY = trigger.moveY;
                    }
                    trigger.gameObject.SetActive(false);
                }
            }
            GameObject camera = GameObject.Find("Main Camera");
            camera.transform.position = new Vector3(offsetX, offsetY, camera.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2.gravityScale < 1)
            spr.flipY = true;
        else
            spr.flipY = false;
        if (GetComponent<Pop>().canPop)
        {
            if ((Input.GetKey(KeyCode.Space) || (GetComponent<Pop>().isAndroid == true && Input.GetMouseButton(0))) && (IsGrounded() == true))
            {
                if (rb2.gravityScale > 1)
                    rb2.velocity = new Vector2(0, 19);
                else
                    rb2.velocity = new Vector2(0, -19);
                buffer = false;
            }
            if ((Input.GetKeyDown(KeyCode.Space) || (GetComponent<Pop>().isAndroid == true && Input.GetMouseButtonDown(0))) && (IsGrounded() == false && IsOrb == false && IsGravityOrb == false))
            {
                buffer = true;
            }
            if ((Input.GetKeyUp(KeyCode.Space) || (GetComponent<Pop>().isAndroid == true && Input.GetMouseButtonUp(0))) && (buffer == true))
            {
                buffer = false;
            }

            if ((Input.GetKeyDown(KeyCode.Space) || (GetComponent<Pop>().isAndroid == true && Input.GetMouseButtonDown(0)) || buffer == true) && (IsOrb == true))
            {
                if (rb2.gravityScale > 1)
                    rb2.velocity = new Vector2(0, 19);
                else
                    rb2.velocity = new Vector2(0, -19);
                IsOrb = false;
                buffer = false;
            }
            if ((Input.GetKeyDown(KeyCode.Space) || (GetComponent<Pop>().isAndroid == true && Input.GetMouseButtonDown(0)) || buffer == true) && IsGravityOrb)
            {
                rb2.velocity = new Vector2(0, 0);
                rb2.gravityScale *= -1;
                IsGravityOrb = false;
                buffer = false;
            }
        }
        else
        {
            deathTimer += Time.deltaTime;
        }
        if (deathTimer > 0.75f)
        {
            SceneManager.LoadScene("SlickBrick");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Snout")
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
            Debug.Log(collision.gameObject.tag);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "UI.Constant")
            IsOrb = true;
        if (collision.tag == "UI.Normal")
        {
            if (rb2.gravityScale > 1)
                rb2.velocity = new Vector2(0, 28);
            else
                rb2.velocity = new Vector2(0, -28);

        }
        if (collision.tag == "UI.Shop")
            IsGravityOrb = true;
        if (collision.tag == "UI.Achievements")
        {
            rb2.velocity = new Vector2(0, rb2.velocity.y / 2);
            rb2.gravityScale = -Mathf.Abs(rb2.gravityScale);
        }
        if (collision.tag == "UI.Achievements1")
        {
            rb2.velocity = new Vector2(0, rb2.velocity.y / 2);
            rb2.gravityScale = Mathf.Abs(rb2.gravityScale);
        }
        if (collision.tag == "UI.Achievements2")
        {
            rb2.velocity = new Vector2(0, 0);
            rb2.gravityScale = -rb2.gravityScale;
            if (rb2.gravityScale > 0) rb2.velocity = new Vector2(0, 28);
            if (rb2.gravityScale < 0) rb2.velocity = new Vector2(0, -28);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsOrb = false;
        IsGravityOrb = false;
    }
}
