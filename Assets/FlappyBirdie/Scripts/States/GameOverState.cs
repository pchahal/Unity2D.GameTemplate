using UnityEngine;
using System.Collections;
using Prime31.StateKit;

public class GameOverState :  SKState<GameController>{
	private Transform gameOverScreen;
	private Transform playingScreen;
    public delegate void EventHandler();    
    public static event EventHandler OnGameOver;

	public override void begin()
	{		
		gameOverScreen = _context.transform.Find ("GameOverScreen");
		gameOverScreen.gameObject.SetActive (true);
        if (OnGameOver != null)
            OnGameOver();

	}
	
	
	public override void reason()
	{
		// here we would check to see if what we are chasing is too far. if it is we can pop state
	}
	
	
	public override void update( float deltaTime )
	{
        if (Input.GetKeyDown(KeyCode.Escape))
            _machine.changeState<StartState>();
	}
	
	
	public override void end()
	{		
		gameOverScreen.gameObject.SetActive (false);
		playingScreen = _context.transform.Find ("PlayingScreen");
		playingScreen.gameObject.SetActive (false);
	}
	
}
