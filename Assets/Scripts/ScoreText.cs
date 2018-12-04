using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //ger tillgång till TMPro 

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI curentScoreText;

    void Start()
    {
        //hämtar TextMeshProUGUI komponenten och länkar den till text
        curentScoreText = GetComponent<TextMeshProUGUI>(); 
    }

    void Update()
    {
        //gör så att det står Coin.score värde på GUI:n
        curentScoreText.text = string.Format("Score: {0:0000}", Coin.score);
    }
}
