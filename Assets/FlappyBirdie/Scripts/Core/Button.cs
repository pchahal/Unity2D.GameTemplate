using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

    public GameObject targetGO;
    public string     targetMethod;
    public AudioClip buttonSound;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        StartCoroutine (audioSource.playClip (buttonSound, ButtonHandler));
    }


    void ButtonHandler()
    {						
        targetGO.SendMessage(targetMethod, SendMessageOptions.RequireReceiver);
    }

		            
}
		