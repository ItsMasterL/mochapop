using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MochometryDash : MonoBehaviour
{
    [SerializeField]
    bool AI = false;
    [SerializeField]
    LayerMask groundLayer;
    [SerializeField]
    LayerMask spikeLayer;
    float deathTimer;
    Rigidbody2D rb2;
    SpriteRenderer spr;
    [SerializeField]
    bool ignoreDamage;
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
    bool IsInWall()
    {
        Vector2 position = transform.position;
        Vector2 direction = new Vector2(1,0f);
        float distance;
        distance = 0.25f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    bool IsNearObstacle()
    {
        Vector2 position = transform.position;
        Vector2 direction = new Vector2(1,0f);
        float distance;
        distance = 2.5f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        distance = 1.5f;
        hit = Physics2D.Raycast(position, direction, distance, spikeLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    bool IsOrb;
    bool IsGravityOrb;
    bool buffer;
    public bool doStartPos;
    public Vector2 startPos;
    [SerializeField]
    float cameraHeight;
    float deathCeiling;
    GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        spr = gameObject.GetComponent<SpriteRenderer>();
        if (doStartPos)
        {
            transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);
            GameObject grid = GameObject.Find("Grid");
            grid.transform.position = new Vector3(-startPos.x - 1, grid.transform.position.y, grid.transform.position.z);
            GameObject.Find("mochapopSlickBrick").GetComponent<AudioSource>().time = startPos.x / 10.386f;
            cam.transform.position = new Vector3(cam.transform.position.x, cameraHeight, cam.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        deathCeiling = cam.transform.position.y + 10;
        if (rb2.gravityScale < 1)
            spr.flipY = true;
        else
            spr.flipY = false;
        if (AI)
        {
            if (GetComponent<SpriteRenderer>().enabled)
            {
                if (IsNearObstacle())
                {
                    GetComponent<Pop>().OpenPop(0.25f);
                }
                if (GetComponent<Pop>().isPopping && (IsGrounded() == true))
                {
                    if (rb2.gravityScale > 1)
                        rb2.velocity = new Vector2(0, 19);
                    else
                        rb2.velocity = new Vector2(0, -19);
                    buffer = false;
                }
                if (GetComponent<Pop>().isPopping && (IsGrounded() == false && IsOrb == false && IsGravityOrb == false))
                {
                    buffer = true;
                }
                if (GetComponent<Pop>().isPopping && (buffer == true))
                {
                    buffer = false;
                }

                if ((GetComponent<Pop>().isPopping || buffer == true) && (IsOrb == true))
                {
                    if (rb2.gravityScale > 1)
                        rb2.velocity = new Vector2(0, 19);
                    else
                        rb2.velocity = new Vector2(0, -19);
                    IsOrb = false;
                    buffer = false;
                }
                if ((GetComponent<Pop>().isPopping || buffer == true) && IsGravityOrb)
                {
                    rb2.velocity = new Vector2(0, 0);
                    rb2.gravityScale *= -1;
                    IsGravityOrb = false;
                    buffer = false;
                }
            }
        }
        else
        {
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
        if (IsInWall() && GetComponent<Pop>().canPop) Dieth();
        
        if (transform.position.y > deathCeiling && GetComponent<Pop>().canPop) Dieth();

    }

    private void Dieth()
    {
        if (ignoreDamage) return;
        if (AI)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Pop>().canPop = false;
            GetComponent<SpriteRenderer>().enabled = false;
        }
        else
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Snout")
        {
            Dieth();
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
            if (rb2.gravityScale > 0)
                rb2.velocity = new Vector2(0, rb2.velocity.y / 2);
            rb2.gravityScale = -Mathf.Abs(rb2.gravityScale);
        }
        if (collision.tag == "UI.Achievements1")
        {
            if (rb2.gravityScale < 0)
                rb2.velocity = new Vector2(0, rb2.velocity.y / 2);
            rb2.gravityScale = Mathf.Abs(rb2.gravityScale);
        }
        if (collision.tag == "UI.Achievements2")
        {
            if (rb2.gravityScale > 0) rb2.velocity = new Vector2(0, 14);
            if (rb2.gravityScale < 0) rb2.velocity = new Vector2(0, -14);
            rb2.gravityScale = -rb2.gravityScale;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsOrb = false;
        IsGravityOrb = false;
    }
}
