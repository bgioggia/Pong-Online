using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    
    public int currentVelocity = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 10 * Time.deltaTime, 0);
            currentVelocity = 10;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
            currentVelocity = -10;
        }
        else
        {
            currentVelocity = 0;
        }
    }
}
