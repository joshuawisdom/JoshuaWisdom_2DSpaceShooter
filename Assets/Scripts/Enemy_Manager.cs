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

public class Enemy_Manager : MonoBehaviour
{
    private float timer;
    private float maxTimer;
    public GameObject enemy;

    public float timerMin = 5f;
    public float timerMax = 12f;

    void Start()
    {
        timer = 0;
        maxTimer = Random.Range(timerMin, timerMax);
        StartCoroutine(SpawnEnemyTimer());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("SpawnEnemyTimer");
    }

    void SpawnEnemy()
    {
        float y = 1.25f;
        Vector3 spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0, 1f), y, 0));
        spawnPoint.z = 0;

        // Adjust x-axis position
        float dist = (this.transform.position - Camera.main.transform.position).z;
        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
        Vector3 enemySize = enemy.GetComponent<Renderer>().bounds.size;
        spawnPoint.x = Mathf.Clamp(spawnPoint.x, leftBorder + enemySize.x / 2, rightBorder - enemySize.x / 2);


        GameObject.Instantiate(enemy, spawnPoint, new Quaternion(0, 0, 0, 0));

    }

    IEnumerator SpawnEnemyTimer()
    {
        //while (true)
        {
            if (timer >= maxTimer)
            {
                // Spawn an enemy
                SpawnEnemy();
                timer = 0;
                maxTimer = Random.Range(timerMin, timerMax);
            }

            timer += 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
