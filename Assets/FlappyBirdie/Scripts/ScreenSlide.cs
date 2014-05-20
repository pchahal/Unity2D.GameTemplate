using UnityEngine;
using System.Collections;

public class ScreenSlide: MonoBehaviour {

	void OnEnable()
	{
		iTween.MoveTo(gameObject, iTween.Hash("y",0,"time",1));
	}
	 
	void OnDisable()
	{
		transform.position = new Vector3 (0, 10, 0);

	}

}
