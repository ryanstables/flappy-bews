using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
  public int score;
  public Text scoreText;
  public GameObject gameOverScreen;
  private bool isGameActive = true;

  [ContextMenu("Add point")]
  public void addPoint() {
    if(!isGameActive) return;
    score++;
    scoreText.text = score.ToString();
  }

  [ContextMenu("Reset")]
  public void reset() {
    score = 0;
    scoreText.text = score.ToString();
  }

  public void restartGame() {
    Debug.Log("RESTARTING");
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void gameOver() {
    gameOverScreen.SetActive(true);
    isGameActive = false;
  }
}
