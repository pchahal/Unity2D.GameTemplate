using UnityEngine;
using System.Collections;
using Prime31.StateKit;

public class StartState : SKState<GameController>{

	private Transform startScreen;

	public override void begin()
	{		
		startScreen = _context.transform.Find ("StartScreen");
		startScreen.gameObject.SetActive (true);
	}	
	
	public override void reason()
	{
		// here we would check to see if what we are chasing is too far. if it is we can pop state
	}	
	
	public override void update( float deltaTime )
	{
		// do the actual chasing and once complete either pop to the previous state or set it directly
	}	
	
	public override void end()
	{
		startScreen.gameObject.SetActive (false);	
	}
	
}
