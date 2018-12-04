using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //ger tillgång till sceneManager 

public class LoadLevel : MonoBehaviour
{

    //sceneToLoad är olika beroende på vilken level som spelas (om det är level 1 så kommer sceneToLoad vara Level 2)


    public int minimumScoreNeeded = 5;
    public string sceneToLoad = "Level 1";

    //kollar om något kolliderar med en trigger
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //om föremålet som kolliderar har tagen "Player" och Coin.score är störe eller lika med minimumScoreNeeded
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded) 
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