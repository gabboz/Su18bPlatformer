using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    //en variabel som kan användas på alla script
    public static int score; 

    public int amount = 1;

    private float spinSpeed = 180;

    private void Update()
    {
        //gör så att coins snurrar i spelet
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0); 
    }
    //kollar om något föremål kolliderar med en trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om föremålet som nuddar detta har tagen "Player" 
        if (collision.tag == ("Player")) 
        {
            //lägg till poäng till "score"
            Coin.score += amount;
            //förstör sig själv 
            Destroy(gameObject); 
        }
    }
}

