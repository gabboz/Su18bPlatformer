using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVerticalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;

    private Rigidbody2D rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    //all med fysik ligger i fixedupdate
    private void FixedUpdate()
    {
        //kollar om left = true
        if (left == true)
        {
            //sätter rbody (på fienden) till vänster och åker framåt
            rbody.velocity = -(Vector2)transform.up * speed;
        }
        else
        {
            //sätter rbody (på fienden) till höger och åker framåt
            rbody.velocity = (Vector2)transform.up * speed;
        }
    }
    //kollar om något kolliderar med en trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        //kollar om föremålet har tagen InvisibleWall
        if (other.tag == ("InvisibleWall"))
        {
            //sätter left till inte left (left = false)
            left = !left;
        }

    }
}
