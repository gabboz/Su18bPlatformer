using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //en variabel som kan användas i alla script
    public static float moveSpeed = 6f;
    //en variabel som kan användas i alla script
    public static float jumpSpeed = 12f; 
    public GroundChecker groundCheck;
    private Rigidbody2D rbody;

    void Start()
    { //hämtar Rigidbody komponenten och länkar den till rbody (spelaren)
        rbody = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        //rbody rör sig om en "Horizontal" knapp trycks (A,D & vänster, höger pil) och gångrar det med moveSpeed
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);
        //när knappen "Jump" trycks ner (spacebar)
        if (Input.GetButtonDown("Jump"))
        {
            //kollar om spelaren är på marken
            if (groundCheck.isGrounded > 0)
            {
                //rbody rör sig uppåt med hjälp av en vector2 som använder rbody:s fart på X axeln och jumpSpeed
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
                //varje gång man trycker på Space så lägger det till 1 till doubleJump variabeln
                GroundChecker.doubleJump += 1;
            }
        }
    }
}
