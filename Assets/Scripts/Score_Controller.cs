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

public class Score_Controller : MonoBehaviour
{
    public int score = 0;

    public void UpdateScore()
    {
        GetComponent<Text>().text = "Score: " + score;
    }
}
