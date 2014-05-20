using UnityEngine;
using System.Collections;


public class ScoreManager : MonoBehaviour 
{		
	public static int score{ get; set; }
	public static int bestScore{ get; set; }


	void Start()
	{
		score = 0;    
        bestScore=GetBestScore();
	}

	private void OnScoredPoint()
	{
		score++;
        if (score > bestScore)
        {
            bestScore=score;          
        }
    }

    private void OnGameOver()
    {       
            SetBestScore(bestScore);       
    }

    private  void SetBestScore(int value)
    {    
        PlayerPrefs.SetInt("bestScore",value);        
    }
    
    private  int GetBestScore()
    {                           
       bestScore = PlayerPrefs.GetInt("bestScore",0);
        return bestScore;
    }

    void Update()
    {
      
    }

    void OnGameReady()
    {
        score = 0;
    }
    	
	void OnEnable()
	{
		FlappyBirdie.OnScoredPoint += OnScoredPoint;			
        GameOverState.OnGameOver    += OnGameOver; 
        GetReadyState.OnGameReady += OnGameReady;
	}
			
	void OnDisable()
	{
		FlappyBirdie.OnScoredPoint -= OnScoredPoint;
        GameOverState.OnGameOver    -= OnGameOver;      
        GetReadyState.OnGameReady -= OnGameReady;
	}
}
