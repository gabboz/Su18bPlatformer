using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    void Start()
    {
        //gör så att spriten stängs av (hämta spriterenderen och stäng av den)
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
