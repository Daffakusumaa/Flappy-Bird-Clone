using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
     public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool isGameOver = false; // Tambahkan status game over
    
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        {
            AudioManager.singleton.PlaySound(2);
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        AudioManager.singleton.PlaySound(1);
        isGameOver = true; // Set status game over menjadi true
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }
}