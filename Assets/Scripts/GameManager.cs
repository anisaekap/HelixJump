using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;
    public int best;
    public int score;
    public int currentStage = 0;
	
	public AudioSource gameOverAudio;
	
    

    private void Awake()
    {
        if (singleton == null)
            singleton = this;
        else if (singleton != this)
            Destroy(gameObject);

        // Load the saved highscore
        best = PlayerPrefs.GetInt("Highscore");
    }

    public void NextLevel()
    {
		
        currentStage++;
        FindObjectOfType<BallController>().ResetBall();
        FindObjectOfType<HelixController>().LoadStage(currentStage);
    }

    public void RestartLevel()
    {
        Debug.Log("Restarting Level");
        // Show Adds Advertisement.Show();
        singleton.score = 0;
        FindObjectOfType<BallController>().ResetBall();
        FindObjectOfType<HelixController>().LoadStage(currentStage);
    }
	
	public void GameOver()
	{
		Application.LoadLevel("Game Over");
		gameOverAudio.Play();
	}

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;

        if (score > best)
        {
            PlayerPrefs.SetInt("Highscore", score);
            best = score;
        }
    }


}
