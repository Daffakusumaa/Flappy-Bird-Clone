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
        if (!isGameOver) // Tambahkan pengecekan status game over
        {
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        isGameOver = true; // Set status game over menjadi true
        gameOverScreen.SetActive(true);
    }
}