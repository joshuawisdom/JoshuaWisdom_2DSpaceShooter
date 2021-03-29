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

public class Background_Controller : MonoBehaviour
{
    public float scrollSpeed;

    private Renderer renderer;
    private Vector2 savedOffset;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(0, y);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
