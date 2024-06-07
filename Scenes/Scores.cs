using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    //The script keep the highscore
    public TMP_Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = "HighScore \n" + PlayerPrefs.GetInt("HighScore").ToString();
    }
    //Resetting the HighScore
    public void ResetTheScore()
    {
        CardGame.score = 0;
        PlayerPrefs.SetInt("HighScore", 0);
    }
    // Update is called once per frame
    void Update()
    {
        highscore.text = "HighScore \n" + PlayerPrefs.GetInt("HighScore").ToString();
        if (CardGame.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", CardGame.score);
        }
    }
}
