using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public int isGrounded;

    //en variabel som kan användas i alla andra script
    static public int doubleJump = 0;

    //kollar om något kolliderar med en trigger
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //sätter isGrounded till 1
        isGrounded = 1;
        //när Player nuddar marken så blir doubleJump resetad
        doubleJump = 0;
    }
    private void Update()
    {
        //om doubleJump blir större än 1
        if(doubleJump > 1)
        {
            //sätter isGrounded till 0
            isGrounded = 0;
        }
    }
}
