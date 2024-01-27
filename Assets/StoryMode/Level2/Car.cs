using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Vector3 initialPos;
    float driveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + driveSpeed, initialPos.y + Random.Range(-0.005f, 0.005f));
        driveSpeed += driveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        driveSpeed = 0.01f;
        collision.collider.enabled = false;
        GetComponent<AudioSource>().Play();
    }
}
