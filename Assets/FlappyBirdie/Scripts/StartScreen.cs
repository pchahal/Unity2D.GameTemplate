using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	// Use this for initialization
    public GameObject soundOnButton;
    public GameObject soundOffButton;
    public AudioListener audioListener;
	

    void OnSound()
    {
        soundOnButton.SetActive(false);
        soundOffButton.SetActive(true);        
								
		AudioListener.volume = 0;

    }

    void OnSoundOff()
    {
        soundOffButton.SetActive(false);
        soundOnButton.SetActive(true);

		AudioListener.volume = 1;

    }
}
