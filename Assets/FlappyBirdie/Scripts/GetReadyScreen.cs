using UnityEngine;
using System.Collections;

public class GetReadyScreen : MonoBehaviour {

	public CameraFade cameraFade;


	public void OnEnable()
	{
		Instantiate (cameraFade, Vector3.zero, Quaternion.identity);
	}


}

