using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody body;
    public Transform spawnLoc;
    Vector3 pos;
    public float speed = 1.5f;
    const float LEFT_BOUNDARY = .37f;
  
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    { 

    }

    void FixedUpdate()
    {

        if (!body.useGravity)
        {
            if (transform.position.x < LEFT_BOUNDARY && transform.position.x > -0.37)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.position += Vector3.left * speed * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {

                    transform.position += Vector3.right * speed * Time.deltaTime;

                }
                if (Input.GetKey(KeyCode.Space))
                {

                    body.useGravity = true;
                }
            }
            else if (transform.position.x < -0.37)
            {
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
            else if (transform.position.x > 0.37)
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            body.useGravity = false;
            this.transform.position = spawnLoc.position;
            body.velocity = new Vector3();
        }



    }

}
