using UnityEngine;
using System.Collections;

public class FlappyBirdie : MonoBehaviour
{
    public float speed = 1;
    public float jumpForce=200;
    public AudioClip audioPoint;
    public AudioClip audioFlap;
    public AudioClip audioHit;
    public AudioClip audioDie;
    public CameraFade camFade;                

    public delegate void EventHandler();
    public static event EventHandler OnScoredPoint;  

    private bool gameOver = false;
    private Vector3 startPos;
    private bool moveUp=false;

    void Awake()
    {
        startPos = transform.position;             
    }
       

    void Update()
    {
        if (!gameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {   
                moveUp=true;
            }
        }       
    }
    void FixedUpdate()
    {
        if (moveUp)
        {          
            MoveUpwards();               
            moveUp=false;;
        }
    }

    void MoveUpwards()
    {
        audio.PlayOneShot(audioFlap);
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.AddForce(new Vector2(0, jumpForce));
    }

    void LateUpdate()
    {                       
        if (gameOver)
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
        else
            rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);

        if (rigidbody2D.velocity.y < 0)
        {
            {
                transform.Rotate(-Vector3.forward, speed * 100 * Time.deltaTime);
                if (transform.eulerAngles.z > 30)
                {
                    float angle = Mathf.Clamp(transform.eulerAngles.z, 270, 360);         
                    transform.rotation = Quaternion.Euler(0, 0, angle);
                }
            }
        }
        else if (rigidbody2D.velocity.y > 0 && !gameOver)
        { 
            transform.rotation = Quaternion.Euler(0, 0, 30);                        
        }               
    }

    void OnTriggerExit2D()
    {   
        if (!gameOver)
        {
            audio.PlayOneShot(audioPoint);
            if (OnScoredPoint != null)
                OnScoredPoint();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameOver && collision.collider.tag != "Ceiling")
        {                                                                                                       
            StartCoroutine(audio.playClip(audioHit, PlayDieSound));                     
            gameOver = true;
            Instantiate(camFade, Vector3.zero, Quaternion.identity);
            Invoke("GameOver", .5f);           
        }           
    }
        
    void PlayDieSound()
    {
        audio.PlayOneShot(audioDie);
    }

    void GameOver()
    {           
        SendMessageUpwards("OnGameOver", SendMessageOptions.RequireReceiver);           
    }

    void OnEnable()
    {              
        gameOver = false;
        transform.position = startPos;    
    }
}
