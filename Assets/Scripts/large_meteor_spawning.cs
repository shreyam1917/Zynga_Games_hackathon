using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class large_meteor_spawning : MonoBehaviour
{
    // Start is called before the first frame update
   

    public GameObject[] meteorPrefabs; // prefabs for each size of meteor
    public float smallMeteorProbability;
    public float mediumMeteorProbability;
    public float largeMeteorProbability;
    public float maxLargeMeteorDistance;
    public float minMeteorSpeed;
    public float maxMeteorSpeed;
    private Transform playerTransform;
    float counter = 1f;
    float timeout = 0;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;


    }

    void Update()
    {
        // calculate the probability of each size meteor spawning
        float totalProbability = smallMeteorProbability + mediumMeteorProbability + largeMeteorProbability;
        float smallProb = smallMeteorProbability / totalProbability;
        float mediumProb = mediumMeteorProbability / totalProbability;
        float largeProb = largeMeteorProbability / totalProbability;

        // determine the distance from the player
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        // spawn a meteor based on the probabilities
        float randomValue = Random.value;
        if (timeout > 40f)
        {
            if (counter > 2.5f)
            {
                if (randomValue < smallProb)
                {
                    Spawn(meteorPrefabs[0], Meteor.Size.Small);
                }
                else if (randomValue < smallProb + mediumProb)
                {
                    Spawn(meteorPrefabs[1], Meteor.Size.Medium);
                }
                /*else if (distance > maxLargeMeteorDistance && randomValue < smallProb + mediumProb + largeProb)
                {
                    Spawn(meteorPrefabs[2], Meteor.Size.Large);
                }*/
                counter = 0;
            }
            counter += Time.deltaTime;
        }
        timeout += Time.deltaTime;
        

    }

    void Spawn(GameObject prefab, Meteor.Size size)
    {
        // instantiate the meteor and set its size and speed
        GameObject meteor = Instantiate(prefab, transform.position, Quaternion.identity);
        Meteor meteorScript = meteor.GetComponent<Meteor>();
        meteorScript.size = size;
        meteorScript.speed = Random.Range(minMeteorSpeed, maxMeteorSpeed);
    }
}
