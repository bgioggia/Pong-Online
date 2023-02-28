using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private Player1 p1;
    private Player2 p2;
    public float xDir = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(xDir, 0, 0);
        p1 = GameObject.Find("Player 1").GetComponent<Player1>();
        p2 = GameObject.Find("Player 2").GetComponent<Player2>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "P1")
        {
            xDir = 10;
            rb.velocity = new Vector3(xDir, p1.currentVelocity, 0);
        }
        else if (collision.gameObject.tag == "P2")
        {
            xDir = -10;
            rb.velocity = new Vector3(xDir, p2.currentVelocity, 0);
        }
        else if (collision.gameObject.tag == "Bottom")
        {
            rb.velocity = new Vector3(xDir, 10, 0);
        }
        else if (collision.gameObject.tag == "Top")
        {
            rb.velocity = new Vector3(xDir, -10, 0);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P1Goal")
        {
            xDir = 10;
            rb.velocity = new Vector3(xDir, 0, 0);
            transform.position = new Vector3(0, 0, 10);
            //p2.score++;
        }
        else if (other.gameObject.tag == "p2Goal") //no consistnecy in naming!!!!!
        {
            xDir = -10;
            rb.velocity = new Vector3(xDir, 0, 0);
            transform.position = new Vector3(0, 0, 10);
            //p1.score++;
        }
    }
}
