//Joshua Wisdom
//2313991
//CPSC 236-03
//jowisdom@chapman.edu
//Project 04: 2D Space Shooter
//This is my own work, and I did not cheat on this assignment.

//No known errors.

//Completed alongside provided videos.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet_Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.WorldToViewportPoint(transform.position).y > 1)
        {
            scoreText.GetComponent<Score_Controller>().score -= 5;
            scoreText.GetComponent<Score_Controller>().UpdateScore();
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject.Destroy(this.gameObject);
            GameObject.Destroy(collision.gameObject);

            scoreText.GetComponent<Score_Controller>().score += 10;
            scoreText.GetComponent<Score_Controller>().UpdateScore();
        }


    }
}
