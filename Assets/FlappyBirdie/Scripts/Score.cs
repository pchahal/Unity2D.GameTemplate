using UnityEngine;
using System.Collections;


public class Score : MonoBehaviour {
      
    protected TextMesh  scoreLabel;
    
    void Awake () 
    {
        scoreLabel = GetComponent<TextMesh>();
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.sortingLayerName = "default";  
        renderer.sortingOrder = 2;
        DrawScore ();   
    }
    
    protected virtual int getScore()
    {
        return ScoreManager.score;     
    }
    
    public void DrawScore() 
    {
        int score = getScore();
        scoreLabel.text = score.ToString();
    }
    
    void OnGameOver()
    {
        DrawScore();
    }       
    
    protected virtual void  OnEnable()
    {    
        FlappyBirdie.OnScoredPoint += DrawScore;          
        GetReadyState.OnGameReady += DrawScore;  
        GameOverState.OnGameOver += OnGameOver;                
    }
    
    protected virtual void   OnDisable()
    {
		FlappyBirdie.OnScoredPoint -= DrawScore;          
        GetReadyState.OnGameReady -= DrawScore;  
        GameOverState.OnGameOver -= OnGameOver;        
    }
}
