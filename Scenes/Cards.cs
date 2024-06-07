using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Cards : MonoBehaviour
{
    //The values of Cards for each colors
    public TMP_Text redvalue, bluevalue, yellowvalue, greenvalue;
    public static int red, blue, yellow, green;

    void Start()
    {
        //Card scales of decks
        red = Random.Range(1, MainMenu.maxcardvalue / 2 + 1);
        blue = Random.Range(1, MainMenu.maxcardvalue / 2 + 1);
        yellow = Random.Range(1, MainMenu.maxcardvalue / 2 + 1);
        green = Random.Range(1, MainMenu.maxcardvalue/2 +1);
       
    }

    void Update()
    {
        //Prints the values in the screen
        redvalue.text = red.ToString() + "/" + MainMenu.maxcardvalue.ToString();
        bluevalue.text = blue.ToString() + "/" + MainMenu.maxcardvalue.ToString();
        yellowvalue.text = yellow.ToString() + "/" + MainMenu.maxcardvalue.ToString();
        greenvalue.text = green.ToString() + "/" + MainMenu.maxcardvalue.ToString();
    }

}
