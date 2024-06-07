using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // It is a maximum limit of the decks
    public static int maxcardvalue;
    //It enters the game
    public void Play()
    {
        SceneManager.LoadScene("GameDifficulty");
    }
    //---------------------------------------------
    //These are Levels of difficulties
    public void Easy()
    {
        maxcardvalue = 15;
        SceneManager.LoadScene("Game");
    }
    public void Normal()
    {
        maxcardvalue = 10;
        SceneManager.LoadScene("Game");
    }
    public void Hard()
    {
        maxcardvalue = 8;
        SceneManager.LoadScene("Game");
    }
    //---------------------------------------
    //It enters main menu in the game
    public void MainMenus()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //----------------------------------------
    //It is pause UI
    public void ContinueGame()
    {
        CardGame.MainMenuButton.SetActive(false);
        CardGame.ContinueButton.SetActive(false);
        CardGame.Pausebackground.SetActive(false);
    }
    public void PauseGame()
    {
        CardGame.MainMenuButton.SetActive(true);
        CardGame.ContinueButton.SetActive(true);
        CardGame.Pausebackground.SetActive(true);
    }
    //-----------------------------------------
    // It shows how to play 
    public void Guide()
    {
        SceneManager.LoadScene("Guide");
    }
    // It finites the game
    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    //Exit the game
    public void Exit()
    {
        Application.Quit();
    }
}
