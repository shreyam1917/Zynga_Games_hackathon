using UnityEngine;
using System.Collections;

public class PowerUps_Spawning : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // an array of game objects to spawn
    public float spawnDelay = 2.0f; // the time delay between spawns
    private float lastSpawnTime = 0.0f; // the time of the last spawn
    float timeout = 0f;

    // Update is called once per frame
    void Update()
    {
        if(timeout> 30f)
        {
            // check if it's time to spawn another object
            if (Time.time - lastSpawnTime >= spawnDelay)
            {
                // choose a random game object from the array
                int index = Random.Range(0, objectsToSpawn.Length);
                GameObject obj = objectsToSpawn[index];

                // spawn the game object at the spawn point
                Instantiate(obj, transform.position, Quaternion.identity);

                // record the time of the last spawn
                lastSpawnTime = Time.time;
            }
        }
        timeout += Time.deltaTime;
       
    }
}