using UnityEngine;
using System.Collections;

public class Bounds : MonoBehaviour {

	public float speed=1;
	private Vector3 startPos;
	
	void Awake()
	{
		startPos = transform.position;		
	}


	void OnBecameInvisible()
	{
		transform.position += new Vector3(14.1f,0,0);		
	}

	void OnEnable()
	{	
		transform.position = startPos;		
	}
}
