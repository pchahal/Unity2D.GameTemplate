using UnityEngine;
using System.Collections;

public class CameraFade : MonoBehaviour {



	public Texture2D whiteTexture;
	public int layer=9;
	public float duration=1;
	private GameObject camFade;
	
	void OnEnable()
	{

		camFade = iTween.CameraFadeAdd (whiteTexture);
		camFade.layer = layer;				
		iTween.CameraFadeTo(iTween.Hash("amount",1,"time",duration));
		iTween.CameraFadeTo(iTween.Hash("amount",0,"time",duration,"delay",duration));
		Invoke ("FinishedFading", duration * 2);
	}


	public void FinishedFading()
	{
		iTween.CameraFadeDestroy();
		Destroy (gameObject);
	}




}
