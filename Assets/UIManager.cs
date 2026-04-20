using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public TextMeshProUGUI finalTimeText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    private bool gameOverShown = false;

    void Start()
    {
        endGamePanel.SetActive(false);
        gameOverShown = false;
    }

    void FixedUpdate()
    {
        scoreText.text = "Score: " + GameController.score;
        livesText.text = "Lives: " + GameController.lives;

        if (GameController.gameOver && !gameOverShown)
        {
            gameOverShown = true;
            endGamePanel.SetActive(true);
            int minutes = Mathf.FloorToInt(GameController.finalTime / 60);
            int seconds = Mathf.FloorToInt(GameController.finalTime % 60);
            finalTimeText.text = string.Format("Remaining Time: {0:00}:{1:00}", minutes, seconds);
        }
    }
}