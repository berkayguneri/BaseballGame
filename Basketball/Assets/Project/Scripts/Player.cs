using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ball;
    public GameObject playerCam;
    

    public float ballDistance = 2f;
    public float throwingForce;

    public bool holdingBall = true;


    private void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    private void Update()
    {
        if (holdingBall)
        {
            ball.transform.position = playerCam.transform.position + playerCam.transform.forward * ballDistance;

            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCam.transform.forward * throwingForce);
            }
        }
        
    }
}
