using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LogicManager : MonoBehaviour
{
    public int playScore;
    public TMP_Text scoreText;
    public GameObject GameOverScreen;

    public void addScore(int scoreToAdd)
    {
        playScore += scoreToAdd;
        scoreText.text = playScore.ToString();
        //Debug.Log("here in addScore medthod: " + playScore);

    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
