using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasEngeller : MonoBehaviour
{
    public GameObject duck;
    float ranY;
    float ranX;
    Vector2 whereToSpawn;
    public float spawnRate = 0.5f;
    public float nextSpawn = 1f;




    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            ranY = Random.Range(17f, 20f);
            ranX = Random.Range(20f, 39f);
            whereToSpawn = new Vector2(ranX, ranY);

            Instantiate(duck, whereToSpawn, Quaternion.identity);
        }
    }
}