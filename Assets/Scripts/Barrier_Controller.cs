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

public class Barrier_Controller : MonoBehaviour
{
    private int health = 0;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
        {
            Destroy(this.gameObject);
            return;
        }

        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        health++;

    }
}
