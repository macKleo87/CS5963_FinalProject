using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceMovement : MonoBehaviour
{

    float stillLength;
    bool goLeft;
    public float speed;
    int moves;

    // Use this for initialization
    void Start()
    {
        stillLength = Random.Range(0.5f, 1.0f);
        goLeft = true;
        moves = 0;
        InvokeRepeating("Movement", 0.0f, stillLength);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Movement()
    {
        if (goLeft)
        {
            /*
            this.transform.position = new Vector3(
            this.transform.position.x + 0.2f,
            this.transform.position.y,
            this.transform.position.z);
            goLeft = false;
            */
            float step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(
            transform.position,
            new Vector3(this.transform.position.x + 0.2f, this.transform.position.y, this.transform.position.z),
            step);
            moves++;
            if (moves >= 4)
            {
                moves = 0;
                goLeft = false;
            }
        }
        else
        {
            /*
            this.transform.position = new Vector3(
            this.transform.position.x - 0.2f,
            this.transform.position.y,
            this.transform.position.z);
            goLeft = true;
            */
            float step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(
            transform.position,
            new Vector3(this.transform.position.x - 0.2f, this.transform.position.y, this.transform.position.z),
            step);
            moves++;
            if (moves >= 4)
            {
                moves = 0;
                goLeft = true;
            }
        }
    }
}