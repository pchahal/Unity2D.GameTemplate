using UnityEngine;
using System.Collections;

public class BestScore : Score {

    protected override int getScore()
    {
        return ScoreManager.bestScore;       
    }

    protected override void  OnEnable()
    {      
        DrawScore();            
    }

}
