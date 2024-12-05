using UnityEngine;
using UnityEngine.UI;
public class PlayerScript : MonoBehaviour
{
    public CameraShake camShake;
    private bool isGameOver = false;
    public Text gameOverText;

    public Text timeText;
    public float currentTime = 30;

    public Text scoreText;
    public int score;
   
    void Update()
    {
        TimeAndScoreManager();
    }
    void TimeAndScoreManager()
    {
        if (isGameOver)
        {
            scoreText.text = "";
            timeText.text = "";
            camShake.startShake = false;

            gameOverText.text = ("GameOver\n" + "Your score is " + score);
            Time.timeScale = 0;

        }
        else
        {
            currentTime -= 1 * Time.deltaTime;
            timeText.text = "Time: " + currentTime.ToString("F0");
            scoreText.text = "score: " + score.ToString();
            if (score < 0 || currentTime <= 0)
            {
                isGameOver = true;
                currentTime = 0;
            }
        }

      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock")
        {
            currentTime -=5;
            score -= 3;
            camShake.startShake = true;
        }
    }

}
