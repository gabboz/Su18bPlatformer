using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //ger tillgång till sceneManager 

public class KillPlayer : MonoBehaviour
{

    //sceneToLoad är olika beroende på vilken level som spelas (det finns prefabs som heter Spikes_Level 2, de prefabs ska användas på level 2 och ingen annan eftersom de är satta att ladda Level 2)

    public string sceneToLoad = "Level 1";

    //kollar om något föremål kolliderar med en trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om föremålet som nuddar detta har tagen "Player" 
        if (collision.tag == "Player")
        {
            //sätter Coin.score värdet till 0
            Coin.score = 0;
            //sätter spelarens jumpSpeed till sitt orginalvärde
            PlayerMovement.jumpSpeed = 12f;
            //sätter spelarens moveSpeed till sitt orginalvärde
            PlayerMovement.moveSpeed = 6f;
            //ladda scene "sceneToLoad"
            SceneManager.LoadScene(sceneToLoad);
        }

    }
}
