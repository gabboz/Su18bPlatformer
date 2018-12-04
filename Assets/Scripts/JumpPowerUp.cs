﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    //kollar om något föremål kolliderar med en trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om föremålet som nuddar detta har tagen "Player" 
        if (collision.tag == ("Player"))
        {
            //ökar Playerns jumpSpeed med 3
            PlayerMovement.jumpSpeed += 3;
            //förstör sig själv 
            Destroy(gameObject);
        }
    }
}
