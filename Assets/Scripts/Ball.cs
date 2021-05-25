using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private ScoreManager scoreManager;

   [HideInInspector] public float ballPosY;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>(); //variable store the script in the beggining 
        Launch(); 
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;  
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        ballPosY = transform.position.y;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player2Goal")
        {
            scoreManager.IncreasePlayer1Score(); //get the function in ScoreManager.cs

        }
        else if(collision.name == "Player1Goal")
        {
            scoreManager.IncreasePlayer2Score(); //get the function in ScoreManager.cs
        }

        ResetBall();

        
    }

    void ResetBall()
    {
        transform.position = new Vector2(0, 0);
        Launch();
    }
}
