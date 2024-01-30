using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSwap : MonoBehaviour
{
    Pop pop;
    [SerializeField]
    bool ai;
    TiltedTower tt;

    private void Start()
    {
        pop = GetComponent<Pop>();
        tt = FindObjectOfType<TiltedTower>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.rotation = transform.position.x > 0 ? new Quaternion(transform.rotation.x, 180, transform.rotation.z, transform.rotation.w) : new Quaternion(transform.rotation.x, 0, transform.rotation.z, transform.rotation.w);
        if ((Input.GetKeyDown(KeyCode.Space) || (pop.isAndroid == true && Input.GetMouseButtonDown(0))) && !ai && pop.canPop)
        {
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -30 && !ai)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("ClumsyFerret");
        }
        if (ai && Random.Range(0, 500) == 5 && transform.position.y < 7 && !pop.isPopping)
        {
            pop.OpenPop(Random.Range(0, 0.5f));
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }
        if (tt.itsJoever)
        {
            GetComponent<Rigidbody2D>().constraints = new RigidbodyConstraints2D();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Rigidbody2D>().constraints = new RigidbodyConstraints2D();
        GetComponent<AudioSource>().Play();
        pop.canPop = false;
    }
}
