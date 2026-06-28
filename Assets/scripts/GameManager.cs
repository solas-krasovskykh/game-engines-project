using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using TMPro;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    [SerializeField] private int levelNumber = 1;
    [SerializeField] private TMP_Text gameoverText;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private Transform player;

    [Header("Events")]
    [SerializeField] private UnityEvent GameoverEvent;

    private bool slowTime = false;

    public void Gameover()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            GameoverEvent.Invoke();
            //Restart();
        }
    }

    public void Restart()
    {
        Time.timeScale = 1; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameoverText()
    {
        gameoverText.text = "Game Over\nYour Score: " + scoreText.text;
    }

    public void WinningText()
    {
        gameoverText.text = "Level " + levelNumber.ToString() + " Cleared!\nYour Score: " + scoreText.text;
    }

    public void SlowTime()
    {
        slowTime = true;
    }

    private void Update()
    {
        if (slowTime == true && Time.timeScale >= 0.02f)
        {
            Time.timeScale -= 0.03f;
        }
        else if (slowTime == true)
        {
            Time.timeScale = 0f;
        }

        if (player.position.y < 0.4f)
        {
            Gameover();
        }

        Debug.Log(Time.timeScale);
    }

    public void loadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
