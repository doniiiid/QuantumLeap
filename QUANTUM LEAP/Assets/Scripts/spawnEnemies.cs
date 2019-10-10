using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    Vector2 spawnLoc; //spawning location
    public float spawnRate = 2f; //how fast
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn){
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8.4f ,8.4f);
            spawnLoc = new Vector2(randX, transform.position.y);
            Instantiate(enemy, spawnLoc, Quaternion.identity);
        }
        
    }
}
