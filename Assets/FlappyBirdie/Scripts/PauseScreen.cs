using UnityEngine;
using System.Collections;

public class PauseScreen : MonoBehaviour {

    public GameObject pauseButton;
    public GameObject resumeButton;

	void OnPause()
    {
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        Time.timeScale = 0.0f;
    }

    void OnResume()
    {
        resumeButton.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }
       

    void OnPlaying()
    {
        pauseButton.SetActive(true);
    }
    void OnGameOver()
    {
        pauseButton.SetActive(false);
        resumeButton.SetActive(false);
    }

    void OnEnable()
    {            
        PlayingState.OnPlaying += OnPlaying;      
        GameOverState.OnGameOver += OnGameOver;
    }
    
    void OnDisable()
    {              
        PlayingState.OnPlaying -= OnPlaying;     
        GameOverState.OnGameOver -= OnGameOver;
    }

}
