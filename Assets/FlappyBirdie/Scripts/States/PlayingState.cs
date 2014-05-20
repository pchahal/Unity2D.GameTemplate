using UnityEngine;
using System.Collections;
using Prime31.StateKit;

public class PlayingState :   SKState<GameController>{

    public delegate void EventHandler();    
    public static event EventHandler OnPlaying;
    private Transform playingScreen;

	public override void begin()
	{		
		playingScreen = _context.transform.Find ("PlayingScreen");
		playingScreen.gameObject.SetActive (true);
        if (OnPlaying != null)
            OnPlaying();     
	}
	
	
	public override void reason()
	{
		// here we would check to see if what we are chasing is too far. if it is we can pop state
	}	
	
	public override void update( float deltaTime )
	{
	}
		
	public override void end()
	{	
	}
	
}
