using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public Transform player;
    	
	void LateUpdate () 
    {	
		transform.position = new Vector3(player.position.x+2f,transform.position.y,transform.position.z);
	}
}
