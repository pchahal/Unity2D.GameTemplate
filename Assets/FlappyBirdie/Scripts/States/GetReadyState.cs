using UnityEngine;
using System.Collections;
using Prime31.StateKit;

public class GetReadyState :  SKState<GameController>{

    public delegate void EventHandler();    
    public static event EventHandler OnGameReady;
    private Transform getReadyScreen;

	public override void begin()
	{		
		getReadyScreen = _context.transform.Find ("GetReadyScreen");
		getReadyScreen.gameObject.SetActive (true);
        if (OnGameReady != null)
            OnGameReady();
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
		getReadyScreen.gameObject.SetActive (false);       

	}


}
