using UnityEngine;
using System.Collections;
using Prime31.StateKit;

public class GameController : MonoBehaviour {

	private SKStateMachine<GameController> _machine;
	private int test;
	
	void Start()
	{	
		// the initial state has to be passed to the constructor
        _machine = new SKStateMachine<GameController>( this, new StartState() );
		_machine.addState( new GetReadyState() );
		_machine.addState( new PlayingState() );
		_machine.addState( new GameOverState() );
	}

	
	void Update()
	{
		_machine.update( Time.deltaTime );     
	}
	
	void OnGetReady()
	{
		_machine.changeState<PlayingState>();
	}

	void OnGameOver()
	{
		_machine.changeState<GameOverState>();
	}

	void OnPlay()
	{
		_machine.changeState<GetReadyState>();
	}

	void OnRate()
	{	
		Application.OpenURL(Settings.googlePlayMarketProductDetails);
	}
	void OnMoreGames()
	{	
		Application.OpenURL(Settings.googlePlayMarketProductList);
	}
}
