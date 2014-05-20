using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

    private Vector3 startPos;	

    void Awake()
    {
        startPos = transform.parent.transform.position;
        StaggerPipe ();
    }


	void OnBecameInvisible()
	{
		transform.parent.transform.position += new Vector3(11.25f,0,0);
		StaggerPipe ();
	}

	void StaggerPipe()
	{	
        int staggerAmount = Random.Range (-1, 4);	
		transform.parent.transform.position = new Vector3(transform.position.x,staggerAmount,transform.position.z);
	}

    void OnPlaying()
    {
        Vector3 parentPipePos = transform.parent.transform.position;
        transform.parent.transform.position = new Vector3(startPos.x, parentPipePos.y, parentPipePos.z);
    }
   
    
    void OnEnable()
    {            
        PlayingState.OnPlaying += OnPlaying;      
    }
    
    void OnDisable()
    {              
        PlayingState.OnPlaying -= OnPlaying;     
    }
}

